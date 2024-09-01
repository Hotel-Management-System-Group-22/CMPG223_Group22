﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HotelManagementSystem.LogIn;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelManagementSystem
{
    public partial class CheckOut : Form
    {

        string sRoomId = "",sGuestId = "",sBookingId ="";
        bool bAfrikaans;
        public CheckOut(bool isAfrikaans)
        {
            InitializeComponent();
            bool bAfrikaans = isAfrikaans;
            checkLanguage();
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
                            
                            if (bAfrikaans == false)
                            {
                                MessageBox.Show("The departure date matches the booking record.");
                            }
                            else
                            {
                                MessageBox.Show("Die vertrekdatum stem ooreen met die besprekingsrekord.");
                            }
                        }
                        else
                        {
                            if (bAfrikaans == false)
                            {
                                MessageBox.Show($"The departure date does not match. Expected: {storedDepartureDate.ToShortDateString()}");
                            }
                            else
                            {
                                MessageBox.Show($"Die vertrekdatum stem nie ooreen nie. Verwag: {storedDepartureDate.ToShortDateString()}");
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
            
            dateTimePicker1.Value = DateTime.Now; 
            LoadData();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
           // string query = "UPDATE Booking SET Guest_Departure= @Value1 WHERE Booking_ID = @ID";
            if (txtBookingID.Text != "" )
            {
                if (IsValueInTable("Booking_ID", txtBookingID.Text))
                {
                   
                            
                    DialogResult result;
                    if (bAfrikaans == false)
                    {
                        result = MessageBox.Show("Are you sure you want to check out? \nBooking ID: " + txtBookingID.Text, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                    else
                    {
                        result = MessageBox.Show("Is jy seker jy wil uitteken? \nBooking ID: " + txtBookingID.Text, "Bevestiging", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                    if (result == DialogResult.Yes)
                    {

                                ValidateArrivalDate(int.Parse(txtBookingID.Text), DateTime.Now);
                    }
                        
                }
                else {
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
            else {
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

        private void CheckOut_Load(object sender, EventArgs e)
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
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    //stack overflow Test!
                    string query = @"SELECT Guest.Guest_FName, Guest.Guest_LName, Room.Room_ID FROM Booking JOIN Guest ON Booking.Guest_ID = Guest.Guest_ID JOIN Room ON Booking.Room_ID = Room.Room_ID WHERE Booking.Booking_ID = @BookingID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@BookingID", txtBookingID.Text);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtGuestFName.Text = reader["Guest_FName"].ToString();
                        txtGuestLName.Text = reader["Guest_LName"].ToString();
                        txtCheckOutRoom.Text = reader["Room_ID"].ToString();
                    }
                    else
                    {
                        // Handle the case where no data is found
                        txtGuestFName.Text = string.Empty;
                        txtGuestLName.Text = string.Empty;
                        txtCheckOutRoom.Text = string.Empty;
                    }

                    reader.Close();
                }
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
            /*
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
            */
           
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            if (bAfrikaans)
            {
                bAfrikaans = false;
            }
            else {
                bAfrikaans = true;
            }
            checkLanguage();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormHelper.ShowAppropriateForm(this, LogIn.isAdmin, LogIn.isClerk, bAfrikaans);

        }

        private void txtRoomID_TextChanged(object sender, EventArgs e)
        {
            /*
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
            */

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void txtCheckOutRoom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGuestFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGuestLName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime searchDate = dateTimePicker1.Value.Date;
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

        private void checkLanguage() {
            if (bAfrikaans)
            {
                btnLanguage.Text = "English";
                lblBookingID.Text = "Bespreking ID:";
                lblGuestFName.Text = "Gas Voornaam:";
                lblGuestLName.Text = "Gas Van:";
                lblRoomID.Text = "Kamer ID:";
                btnBookingUpdate.Text = "Opdateer bespreking";
                btnCheckOut.Text = "Teken uit";
                btnCheckOutCancel.Text = "Kanselleer";
                toolTip1.SetToolTip(btnCheckOutCancel, "Stel die vorm terug na sy oorsprong.");
                toolTip1.SetToolTip(btnCheckOut, "Teken die bespreking uit.");
                toolTip1.SetToolTip(btnLanguage, "Verander die taal vir die vorm.");
                toolTip1.SetToolTip(btnBookingUpdate, "Gaan na die besprekings vorm toe om veranderinge te maak.");
               // toolTip1.SetToolTip(txtRoomID, "Tik die Kamer ID in van die bespreeking.");
                toolTip1.SetToolTip(txtBookingID, "Tik die Bespreking ID in van die bespreeking.");
                //toolTip1.SetToolTip(txtGuestID, "Tik die Gas ID in van die bespreeking.");


            }
            else
            {
                btnLanguage.Text = "Afrikaans";
                lblBookingID.Text = "Booking ID:";
                lblGuestFName.Text = "Guest First Name:";
                lblGuestLName.Text = "Guest Last Name:";
                lblRoomID.Text = "Room ID:";
                btnBookingUpdate.Text = "Update Booking ID";
                btnCheckOut.Text = "Check Out";
                btnCheckOutCancel.Text = "Cancel";
                toolTip1.SetToolTip(btnCheckOutCancel, "Reset the form to its default state before adding a new entry.");
                toolTip1.SetToolTip(btnCheckOut, "Check the customer out.");
                toolTip1.SetToolTip(btnBookingUpdate, "Go to the bookings from to update the booking.");
                toolTip1.SetToolTip(btnLanguage, "Switch between available languages.");
                //toolTip1.SetToolTip(txtRoomID, "Type in the Bookings Room ID.");
                toolTip1.SetToolTip(txtBookingID, "Type in the Booking ID.");
                //toolTip1.SetToolTip(txtGuestID, "Type in the Bookings Guest ID.");
            }
        }
    }
}
