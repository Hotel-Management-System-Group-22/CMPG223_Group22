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
                            MessageBox.Show("The arrival date matches the booking record.");
                        }
                        else
                        {
                            MessageBox.Show($"The arrival date does not match. Expected: {storedArrivalDate.ToShortDateString()}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No booking found with the specified ID.");
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
            if (txtBookingID.Text != "" && txtGuestID.Text != "" && txtRoomID.Text != "")
            {
                if (IsValueInTable("Booking_ID",txtBookingID.Text))
                {
                    if (IsValueInTable("Guest_ID", txtGuestID.Text))
                    {
                        if (IsValueInTable("Room_ID", txtRoomID.Text))
                        {
                            DialogResult result = MessageBox.Show("Are you sure you want to check in? \nBooking ID: " + txtBookingID.Text, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {

                                ValidateArrivalDate(int.Parse(txtBookingID.Text),DateTime.Now);                               

                            }
                        }else { MessageBox.Show("Room ID does not exist"); }
                    }else { MessageBox.Show("Guest ID does not exist"); }
                }else { MessageBox.Show("Booking ID does not exist"); }

            }else { MessageBox.Show("Fields cannot be Empty"); }
            
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
            UpdateDataGridView(txtBookingID.Text, dataGridView1, "SELECT * FROM Booking WHERE Booking_ID LIKE @searchTerm");
        }

        private void txtGuestID_TextChanged(object sender, EventArgs e)
        {
            UpdateDataGridView(txtGuestID.Text, dataGridView1, "SELECT * FROM Booking WHERE Guest_ID LIKE @searchTerm");
        }

        private void txtRoomID_TextChanged(object sender, EventArgs e)
        {
            UpdateDataGridView(txtRoomID.Text, dataGridView1, "SELECT * FROM Booking WHERE Room_ID LIKE @searchTerm");
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