using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class CheckIn : Form
    {
        string sRoomId = "", sGuestId = "", sBookingId = "";
        bool bAfrikaans = false;
        public CheckIn()
        {
            InitializeComponent();
        }
        string connection = "Data Source=(Localdb)\\MSSQLLocalDB;Database=Cmpg223;Trusted_Connection=True;";

        private void LoadData()
        {
            string query = "SELECT * FROM Booking";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }
        private void UpdateDataGridView(string searchTerm, DataGridView dataGridView, string query)
        {

            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@searchTerm", $"%{searchTerm.Trim()}%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            dataGridView.DataSource = dataTable;
        }

        public void ValidateArrivalDate(int bookingId, DateTime userProvidedArrivalDate)
        {
            

            //  Write the SQL query to get the ArrivalDate for a specific booking
            string query = "SELECT Guest_Arrival  FROM Booking WHERE Booking_ID = @BookingID";

            //  Connect to the database and execute the query
            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    // Add the BookingID parameter to the query
                    command.Parameters.AddWithValue("@BookingID", bookingId);

                    // Open the connection and execute the query
                    conn.Open();
                    object result = command.ExecuteScalar();

                    //  Check if the ArrivalDate was retrieved
                    if (result != null)
                    {
                        DateTime storedArrivalDate = (DateTime)result;

                        //Compare the stored arrival date with the user-provided date
                        if (storedArrivalDate.Date == userProvidedArrivalDate.Date)
                        {
                           
                            if (bAfrikaans == false)
                            {
                                MessageBox.Show("The arrival date matches the booking record.");
                            }
                            else
                            {
                                MessageBox.Show("Die aankomsdatum stem ooreen met die besprekingsrekord.");
                            }
                        }
                        else
                        {
                            if (bAfrikaans == false)
                            {
                                MessageBox.Show($"The arrival date does not match. Expected: {storedArrivalDate.ToShortDateString()}");
                            }
                            else
                            {
                                MessageBox.Show($"Die aankomsdatum stem nie ooreen nie. Verwag: {storedArrivalDate.ToShortDateString()}");
                            }
                            
                        }
                    }
                    else
                    {
                        if (bAfrikaans == false)
                        {
                            MessageBox.Show("Booking ID does not exist.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Bespreking ID bestaan nie.", "Ongeldige Invoer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }
        public bool IsValueInTable(string columnName, object value)
        {
            string query = "";


            if (columnName == "Room_ID")
            {
                // Write the SQL query to check if the value exists in the specified column
                query = $"SELECT COUNT(*) FROM Room WHERE {columnName} = @Value";
            }
            else if (columnName == "Guest_ID")
            {            
                    // Write the SQL query to check if the value exists in the specified column
                    query = $"SELECT COUNT(*) FROM Guest WHERE {columnName} = @Value";
               
            }else if (columnName == "Booking_ID")
            {
                    // Write the SQL query to check if the value exists in the specified column
                    query = $"SELECT COUNT(*) FROM Booking WHERE {columnName} = @Value";
              
            }



            // Connect to the database and execute the query
            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    //  Add the parameter to the query
                    command.Parameters.AddWithValue("@Value", value);

                    // Open the connection and execute the query
                    conn.Open();
                    int count = (int)command.ExecuteScalar();

                    // Return true if the value exists, otherwise false
                    return count > 0;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtRoomID.Text = string.Empty;
            txtGuestID.Text = string.Empty;
            txtBookingID.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
            LoadData();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Booking SET Guest_Arrival= @Value1 WHERE Booking_ID = @ID";
            if (txtBookingID.Text != "" )
            {
                if (IsValueInTable("Booking_ID",txtBookingID.Text))
                {
                    DialogResult result;
                    if (bAfrikaans == false)
                    {
                        result = MessageBox.Show("Are you sure you want to check in? \nBooking ID: " + txtBookingID.Text, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                    else
                    {
                        result = MessageBox.Show("Is jy seker jy wil inteken? \nBooking ID: " + txtBookingID.Text, "Bevestiging", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                    if (result == DialogResult.Yes)
                        {
                            ValidateArrivalDate(int.Parse(txtBookingID.Text),DateTime.Now);                               

                         }                        
                }else {
                    if (bAfrikaans == false)
                    {
                        MessageBox.Show("Booking ID does not exist.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Bespreking ID bestaan nie.", "Ongeldige Invoer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }else {
                if (bAfrikaans == false)
                {
                    MessageBox.Show("Fields cannot be Empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Velde mag nie leeg wees nie.", "Ongeldige Invoer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }

        private void btnBookingUpdate_Click(object sender, EventArgs e)
        {
            //Booking booking = new Booking();
            //booking.ShowDialog();
        }

        private void CheckIn_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtBookingID_TextChanged(object sender, EventArgs e)
        {

            // Try to parse the text in the TextBox to an integer
            if ((int.TryParse(txtBookingID.Text, out int result)) || (txtBookingID.Text == string.Empty))
            {
                // The input is a valid integer
                UpdateDataGridView(txtBookingID.Text, dataGridView1, "SELECT * FROM Booking WHERE Booking_ID LIKE @searchTerm");
                sBookingId = txtBookingID.Text;
            }
            else
            {
                // The input is not a valid integer
                if (bAfrikaans)
                {
                    MessageBox.Show("Voer asseblief 'n geldige heelgetal in.", "Ongeldige Invoer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                txtBookingID.Text = sBookingId;
                txtBookingID.Select(txtBookingID.Text.Length, 0);

            }
            
        }

        private void txtGuestID_TextChanged(object sender, EventArgs e)
        {
            // Try to parse the text in the TextBox to an integer
            if ((int.TryParse(txtGuestID.Text, out int result)) || (txtGuestID.Text == string.Empty))
            {
                // The input is a valid integer
                UpdateDataGridView(txtGuestID.Text, dataGridView1, "SELECT * FROM Booking WHERE Guest_ID LIKE @searchTerm");
                sGuestId = txtGuestID.Text;
            }
            else
            {
                // The input is not a valid integer
                if (bAfrikaans)
                {
                    MessageBox.Show("Voer asseblief 'n geldige heelgetal in.", "Ongeldige Invoer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                txtGuestID.Text = sGuestId;
                txtGuestID.Select(txtGuestID.Text.Length, 0);

            }
           
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            if (bAfrikaans == false)
            {
                bAfrikaans = true;
                btnLanguage.Text = "English";
                lblBookingID.Text = "Bespreking ID";
                lblGuestID.Text = "Gas ID";
                lblRoomID.Text = "Kamer ID";
                btnBookingUpdate.Text = "Opdateer bespreking";
                btnCheckIn.Text = "Teken uit";
                btnCancel.Text = "Kanselleer";


            }
            else
            {
                bAfrikaans = false;
                btnLanguage.Text = "Afrikaans";
                lblBookingID.Text = "Booking ID";
                lblGuestID.Text = "Guest ID";
                lblRoomID.Text = "Room ID";
                btnBookingUpdate.Text = "Update Booking ID";
                btnCheckIn.Text = "Check Out";
                btnCancel.Text = "Cancel";
            }
        }

        private void txtRoomID_TextChanged(object sender, EventArgs e)
        {
            // Try to parse the text in the TextBox to an integer
            if ((int.TryParse(txtRoomID.Text, out int result)) || (txtRoomID.Text == string.Empty))
            {
                // The input is a valid integer
                UpdateDataGridView(txtRoomID.Text, dataGridView1, "SELECT * FROM Booking WHERE Room_ID LIKE @searchTerm");
                sRoomId = txtRoomID.Text;
            }
            else
            {
                // The input is not a valid integer
                if (bAfrikaans)
                {
                    MessageBox.Show("Voer asseblief 'n geldige heelgetal in.", "Ongeldige Invoer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                txtRoomID.Text = sRoomId;
                txtRoomID.Select(txtRoomID.Text.Length, 0);

            }

            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
            DateTime searchDate =dateTimePicker1.Value.Date;
            DataTable dataTable = new DataTable();

            //Write the SQL query to filter bookings by the selected Guest_Arrival date
            string query = "SELECT * FROM Booking WHERE Guest_Arrival = @Guest_Arrival";

            //  Connect to the database and execute the query
            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    // Add the selected date parameter to the query
                    command.Parameters.AddWithValue("@Guest_Arrival", searchDate.Date);

                    //Create a DataAdapter to execute the query and fill a DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable searchTerm = new DataTable();

                    // Fill the DataTable with the query results
                    adapter.Fill(dataTable);

                    //Bind the DataTable to the GridView
                    dataGridView1.DataSource = dataTable;
                }
            }
            
        }
    }
}