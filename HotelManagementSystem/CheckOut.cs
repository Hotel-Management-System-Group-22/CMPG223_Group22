using System;
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
    public partial class CheckOut : Form
    {
        public CheckOut()
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

        public void ValidateArrivalDate(int bookingId, DateTime userProvidedArrivalDate)
        {


            //  Write the SQL query to get the DepartureDate for a specific booking
            string query = "SELECT Guest_Departure  FROM Booking WHERE Booking_ID = @BookingID";

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

                    //  Check if the DepartureDate was retrieved
                    if (result != null)
                    {
                        DateTime storedDepartureDate = (DateTime)result;

                        //Compare the stored departure date with the user-provided date
                        if (storedDepartureDate.Date == userProvidedArrivalDate.Date)
                        {
                            MessageBox.Show("The departure date matches the booking record.");
                        }
                        else
                        {
                            MessageBox.Show($"The departure date does not match. Expected: {storedDepartureDate.ToShortDateString()}");
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

            }
            else if (columnName == "Booking_ID")
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
        private void btnCheckOutCancel_Click(object sender, EventArgs e)
        {
            txtBookingID.Text = string.Empty;
            txtGuestID.Text = string.Empty;
            txtRoomID.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Booking SET Guest_Departure= @Value1 WHERE Booking_ID = @ID";
            if (txtBookingID.Text != "" && txtGuestID.Text != "" && txtRoomID.Text != "")
            {
                if (IsValueInTable("Booking_ID", txtBookingID.Text))
                {
                    if (IsValueInTable("Guest_ID", txtBookingID.Text))
                    {
                        if (IsValueInTable("Room_ID", txtRoomID.Text))
                        {
                            DialogResult result = MessageBox.Show("Are you sure you want to edit this record? \nBooking ID: " + txtBookingID.Text, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {

                                ValidateArrivalDate(int.Parse(txtBookingID.Text), DateTime.Now);
                                /*
                                /*
                               using (SqlConnection conn = new SqlConnection(connection))
                               {
                                   SqlCommand command = new SqlCommand(query, conn);

                                   // Add parameters to the SqlCommand
                                   command.Parameters.AddWithValue("@Value1", DateTime.Now);
                                   command.Parameters.AddWithValue("@ID", txtBookingID.Text);

                                   try
                                   {
                                       conn.Open();
                                       int rowsAffected = command.ExecuteNonQuery();
                                       if (rowsAffected > 0)
                                       {
                                           Console.WriteLine("Insert successful.");
                                       }
                                       else
                                       {
                                           Console.WriteLine("Insert failed.");
                                       }
                                   }
                                   catch (Exception ex)
                                   {
                                       Console.WriteLine("An error occurred: " + ex.Message);
                                   }
                               }
                               */
                            }
                        }
                        else { MessageBox.Show("Room ID does not exist"); }
                    }
                    else { MessageBox.Show("Guest ID does not exist"); }
                }
                else { MessageBox.Show("Booking ID does not exist"); }

            }
            else { MessageBox.Show("Fields cannot be Empty"); }
        }

        private void btnBookingUpdate_Click(object sender, EventArgs e)
        {
            //Booking booking = new Booking();
            //booking.ShowDialog();
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
