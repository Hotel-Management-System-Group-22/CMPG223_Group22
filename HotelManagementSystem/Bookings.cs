using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelManagementSystem
{
    public partial class Bookings : Form
    {
        public Bookings()
        {
            InitializeComponent();
        }
        string connection = "Data Source=CAITLIN\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True;";
        private void ValidateTextBox(System.Windows.Forms.TextBox textBox)
        {
            if (textBox != null)
            {
                string input = textBox.Text;
                if (!IsTextValid(input))
                {
                    errorProvider1.SetError(textBox, "Input must contain only letters and first letter must be capitilized.");
                }
                else
                {
                    errorProvider1.SetError(textBox, string.Empty);
                }
            }
            else
            {
                errorProvider1.SetError(textBox, "Please fill the textbox");
            }
        }

        private bool IsTextValid(string text)
        {
            // Regular expression to match only letters (Ensures that first letter is capitalized and rest lowercase)
            Regex regex = new Regex("^[A-Z][a-zA-Z]*$");
            return regex.IsMatch(text);
        }
        private bool IsTextDigitsValid(string text)
        {
            // Regular expression to match only digits
            Regex regex = new Regex("^[0-9]+$");
            return regex.IsMatch(text);
        }
        private void LoadBookingData()
        {
            string query = "SELECT * FROM Booking";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView
                bookingsDataGridView.DataSource = dataTable;
            }
        }
        private void UpdateRoomStatus(int roomId, DateTime arrivalDate, DateTime departureDate, bool isBooked)
        {
            // Define the status based on the booking state
            int status = isBooked ? 1 : 0;

            // Update the room status in the database
            string updateStatusQuery = @"
        UPDATE Room
        SET Status = @status
        WHERE Room_ID = @roomId
        AND EXISTS (
            SELECT 1
            FROM Booking
            WHERE Room_ID = @roomId
            AND Guest_Arrival <= @departureDate
            AND Guest_Departure >= @arrivalDate
        )";

            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(updateStatusQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@roomId", roomId);
                        cmd.Parameters.AddWithValue("@arrivalDate", arrivalDate);
                        cmd.Parameters.AddWithValue("@departureDate", departureDate);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Optionally handle the result
                        if (rowsAffected == 0)
                        {
                            // Handle the case where no rows were updated
                            Console.WriteLine("No matching room found or status was not updated.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Log or handle the exception as needed
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }


        private void btnAddEmp_Click(object sender, EventArgs e)
        {

            ValidateTextBox(txtGuestLNameAdd);
            ValidateTextBox(txtGuestLNameAdd);
            if (!IsTextDigitsValid(txtRoomNrAdd.Text))
            {
                if (txtRoomNrAdd.Text == null)
                {
                    errorProvider1.SetError(txtRoomNrAdd, "Please add room number");
                }
                errorProvider1.SetError(txtRoomNrAdd, "Room number can only contain digits");
            }
            else
            {
                errorProvider1.SetError(txtRoomNrAdd, string.Empty);
            }

            string guestFName = txtGuestFNameAdd.Text;
            string guestLName = txtGuestLNameAdd.Text;
            int guestId = -1;


            if (string.IsNullOrEmpty(errorProvider1.GetError(txtGuestFNameAdd)) && string.IsNullOrEmpty(errorProvider1.GetError(txtGuestLNameAdd)) && string.IsNullOrEmpty(errorProvider1.GetError(txtRoomNrAdd)) && string.IsNullOrEmpty(errorProvider1.GetError(dtCheckin)) && string.IsNullOrEmpty(errorProvider1.GetError(dtCheckout))) {

                // Get Guest_ID based on Guest Name
                string searchGuestQuery = "SELECT Guest_ID FROM Guest WHERE Guest_FName = @guestFName AND Guest_LName = @guestLName";
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(searchGuestQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@guestFName", guestFName);
                        cmd.Parameters.AddWithValue("@guestLName", guestLName);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                guestId = Convert.ToInt32(reader["Guest_ID"]);
                            }
                            else
                            {
                                MessageBox.Show("Guest not found. Please add guest to system before completing booking");
                                return;
                            }
                        }
                    }

                    if (guestId != -1)
                    {
                        int roomId = Convert.ToInt32(txtRoomNrAdd.Text);
                        DateTime arrivalDate = dtCheckin.Value;
                        DateTime departureDate = dtCheckout.Value;

                        // Check if the room exists
                        string checkRoomExistenceQuery = "SELECT COUNT(*) FROM Room WHERE Room_ID = @roomId";
                        using (SqlCommand cmdExistence = new SqlCommand(checkRoomExistenceQuery, conn))
                        {
                            cmdExistence.Parameters.AddWithValue("@roomId", roomId);

                            int roomExists = Convert.ToInt32(cmdExistence.ExecuteScalar());
                            if (roomExists == 0)
                            {
                                MessageBox.Show("The selected room does not exist.");
                                return;
                            }
                        }

                        // Check room availability
                        string checkRoomAvailabilityQuery = "SELECT COUNT(*) FROM Booking WHERE Room_ID = @roomId AND (Guest_Arrival <= @departureDate AND Guest_Departure >= @arrivalDate)";
                        using (SqlCommand cmdAvailability = new SqlCommand(checkRoomAvailabilityQuery, conn))
                        {
                            cmdAvailability.Parameters.AddWithValue("@roomId", roomId);
                            cmdAvailability.Parameters.AddWithValue("@arrivalDate", arrivalDate);
                            cmdAvailability.Parameters.AddWithValue("@departureDate", departureDate);

                            int count = Convert.ToInt32(cmdAvailability.ExecuteScalar());
                            if (count > 0)
                            {
                                MessageBox.Show("The selected room is not available for the chosen dates.");
                                return;
                            }
                        }


                        // Insert the new booking
                        string insertBookingQuery = "INSERT INTO Booking (Guest_ID, Room_ID, Guest_Arrival, Guest_Departure) VALUES (@guestId, @roomId, @arrivalDate, @departureDate)";
                        using (SqlCommand cmd = new SqlCommand(insertBookingQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@guestId", guestId);
                            cmd.Parameters.AddWithValue("@roomId", roomId);
                            cmd.Parameters.AddWithValue("@arrivalDate", arrivalDate);
                            cmd.Parameters.AddWithValue("@departureDate", departureDate);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Booking added successfully.");
                                UpdateRoomStatus(roomId, arrivalDate, departureDate, true);
                            }
                            else
                            {
                                MessageBox.Show("Failed to add booking.");
                            }
                        }
                    }
                }
                LoadBookingData();
            }
            else
            {
                MessageBox.Show("Please complete all fields and ensure all errors are corrected");
            }

        }

        private void dtCheckin_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedCheckinDate = dtCheckin.Value.Date;
            DateTime currentDate = DateTime.Today;

            if (selectedCheckinDate < currentDate)
            {
                errorProvider1.SetError(dtCheckin, "The check-in date cannot be in the past. Please select a valid date.");
                // Optionally, reset the date picker to the current date
                dtCheckin.Value = currentDate;
            }
        }

        private void dtCheckout_ValueChanged(object sender, EventArgs e)
        {
            int maxBookingDuration = 30;

            DateTime selectedCheckoutDate = dtCheckout.Value.Date;
            DateTime selectedCheckinDate = dtCheckin.Value.Date;
            TimeSpan duration = selectedCheckoutDate - selectedCheckinDate;

            if (selectedCheckoutDate == selectedCheckinDate)
            {
                errorProvider1.SetError(dtCheckout, "Booking has to be for at least one day");
            }
            if (duration.Days > maxBookingDuration)
            {
                MessageBox.Show("The maximum booking duration is 30 days. Please select a shorter stay.");
            }
            if (selectedCheckoutDate < selectedCheckinDate)
            {
                MessageBox.Show("Departure date cannot be before Arrival date!");
            }

        }

        private void txtGuestFNameAdd_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(txtGuestFNameAdd);
        }

        private void txtGuestLNameAdd_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(txtGuestLNameAdd);
        }

        private void txtRoomNrAdd_TextChanged(object sender, EventArgs e)
        {
            if (!IsTextDigitsValid(txtRoomNrAdd.Text))
            {
                if (txtRoomNrAdd.Text == null)
                {
                    errorProvider1.SetError(txtRoomNrAdd, "Please add room number");
                }
                errorProvider1.SetError(txtRoomNrAdd, "Room number can only contain digits");
            }
            else
            {
                errorProvider1.SetError(txtRoomNrAdd, string.Empty);
            }
        }

        private void btnAddReset_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            txtGuestLNameAdd.Text = " ";
            txtRoomNrAdd.Text = " ";
            txtGuestFNameAdd.Text = " ";
            dtCheckin.Value = today;
            dtCheckin.Value = today;
        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(errorProvider1.GetError(txtRoomNr_Update)) && string.IsNullOrEmpty(errorProvider1.GetError(dtArrival_Update)))
            {

                if (selectedBookingId == -1)
                {
                    MessageBox.Show("No booking selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int roomId;
                if (!int.TryParse(txtRoomNr_Update.Text, out roomId))
                {
                    MessageBox.Show("Please enter a valid room number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime newArrivalDate = dtArrival_Update.Value;
                DateTime newDepartureDate = dtDeparture_Update.Value;


                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        // Check for overlapping bookings
                        string checkOverlapQuery = @"
                    SELECT COUNT(*)
                    FROM Booking
                    WHERE Room_ID = @roomId
                    AND Booking_ID != @bookingId
                    AND (Guest_Arrival <= @newDepartureDate AND Guest_Departure >= @newArrivalDate)";

                        using (SqlCommand cmdCheckOverlap = new SqlCommand(checkOverlapQuery, conn, transaction))
                        {
                            cmdCheckOverlap.Parameters.AddWithValue("@roomId", roomId);
                            cmdCheckOverlap.Parameters.AddWithValue("@bookingId", selectedBookingId);
                            cmdCheckOverlap.Parameters.AddWithValue("@newArrivalDate", newArrivalDate);
                            cmdCheckOverlap.Parameters.AddWithValue("@newDepartureDate", newDepartureDate);

                            int overlapCount = Convert.ToInt32(cmdCheckOverlap.ExecuteScalar());
                            if (overlapCount > 0)
                            {
                                MessageBox.Show("The room is already booked for those dates.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                transaction.Rollback();
                                return;
                            }
                        }

                        // Update the booking with new dates
                        string updateBookingQuery = @"
                    UPDATE Booking
                    SET Guest_Arrival = @newArrivalDate,
                        Guest_Departure = @newDepartureDate,
                        Room_ID = @newRoom
                    WHERE Booking_ID = @bookingId";

                        using (SqlCommand cmdUpdateBooking = new SqlCommand(updateBookingQuery, conn, transaction))
                        {
                            cmdUpdateBooking.Parameters.AddWithValue("@newArrivalDate", newArrivalDate);
                            cmdUpdateBooking.Parameters.AddWithValue("@newDepartureDate", newDepartureDate);
                            cmdUpdateBooking.Parameters.AddWithValue("@newRoom", roomId);
                            cmdUpdateBooking.Parameters.AddWithValue("@bookingId", selectedBookingId);

                            int rowsAffected = cmdUpdateBooking.ExecuteNonQuery();
                            if (rowsAffected == 0)
                            {
                                MessageBox.Show("No booking was updated. Please check the booking ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                transaction.Rollback();
                                return;
                            }
                        }

                        // Commit the transaction if everything is okay
                        transaction.Commit();
                        MessageBox.Show("Booking updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadBookingData(); // Refresh booking data
                    }
                    catch (Exception ex)
                    {
                        // Rollback the transaction if something went wrong
                        transaction.Rollback();
                        MessageBox.Show("Error updating booking: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else 
            {
                MessageBox.Show("Please complete all fields and ensure all errors are corrected");
            }
        }





        private void Bookings_Load(object sender, EventArgs e)
        {
            LoadBookingData();
        }
        private void PopulateBookingDeleteFields(int bookingId)
        {
            // First query to get guest details using the Guest_ID from the Booking table
            string guestQuery = @"SELECT g.Guest_FName, g.Guest_LName 
                          FROM Guest g
                          INNER JOIN Booking b ON g.Guest_ID = b.Guest_ID
                          WHERE b.Booking_ID = @bookingId";

            // Second query to get booking details
            string bookingQuery = @"SELECT Booking_ID, Room_ID, Guest_Arrival, Guest_Departure 
                            FROM Booking 
                            WHERE Booking_ID = @bookingId";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                // Execute the first query to get guest details
                using (SqlCommand guestCommand = new SqlCommand(guestQuery, conn))
                {
                    guestCommand.Parameters.AddWithValue("@bookingId", bookingId);

                    using (SqlDataReader reader = guestCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtGuestFName_Delete.Text = reader["Guest_FName"].ToString();
                            txtGuestLName_Delete.Text = reader["Guest_LName"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Guest not found for the selected booking ID. Please ensure the Booking ID is correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                // Execute the second query to get booking details
                using (SqlCommand bookingCommand = new SqlCommand(bookingQuery, conn))
                {
                    bookingCommand.Parameters.AddWithValue("@bookingId", bookingId);

                    using (SqlDataReader reader = bookingCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            label.Text = reader["Booking_ID"].ToString();
                            txtRoomNr_Delete.Text = reader["Room_ID"].ToString();
                            if (reader["Guest_Arrival"] != DBNull.Value)
                            {
                                DateTime arrivalDate = Convert.ToDateTime(reader["Guest_Arrival"]);
                                txtArrival.Text = arrivalDate.ToString("yyyy-MM-dd"); // Or another format
                            }
                            else
                            {
                                txtArrival.Text = "N/A"; // Or another default value
                            }

                            if (reader["Guest_Departure"] != DBNull.Value)
                            {
                                DateTime departureDate = Convert.ToDateTime(reader["Guest_Departure"]);
                                txtDeparture.Text = departureDate.ToString("yyyy-MM-dd"); // Or another format
                            }
                            else
                            {
                                txtDeparture.Text = "N/A"; // Or another default value
                            }
                        }
                        else
                        {
                            MessageBox.Show("Booking not found with the selected ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }



        private int selectedBookingId = -1;
        private void btnDeleteEmp_Click(object sender, EventArgs e)
        {
            // Check if a booking is selected
            if (selectedBookingId == -1)
            {
                MessageBox.Show("No booking selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ensure the confirmation checkbox is checked
            if (!cmbConfirm.Checked)
            {
                MessageBox.Show("Please confirm that you want to delete this booking by checking the confirmation box.", "Confirmation Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Retrieve guest name and booking details for confirmation
            string guestQuery = @"SELECT g.Guest_FName, g.Guest_LName 
                      FROM Guest g 
                      INNER JOIN Booking b ON g.Guest_ID = b.Guest_ID 
                      WHERE b.Booking_ID = @bookingId";

            string bookingQuery = @"SELECT b.Room_ID, b.Guest_Arrival, b.Guest_Departure 
                            FROM Booking b 
                            WHERE b.Booking_ID = @bookingId";

            string guestName = "";
            int roomId = -1;
            DateTime arrivalDate = DateTime.MinValue;
            DateTime departureDate = DateTime.MinValue;

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                // Retrieve guest details
                using (SqlCommand command = new SqlCommand(guestQuery, conn))
                {
                    command.Parameters.AddWithValue("@bookingId", selectedBookingId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtGuestFName_Delete.Text = reader["Guest_FName"].ToString() ;
                            txtGuestLName_Delete.Text = reader["Guest_LName"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No guest found with the selected booking ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                // Retrieve booking details
                using (SqlCommand command = new SqlCommand(bookingQuery, conn))
                {
                    command.Parameters.AddWithValue("@bookingId", selectedBookingId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            roomId = Convert.ToInt32(reader["Room_ID"]);
                            arrivalDate = Convert.ToDateTime(reader["Guest_Arrival"]);
                            departureDate = Convert.ToDateTime(reader["Guest_Departure"]);

                            // Populate form fields with booking details
                            txtRoomNr_Delete.Text = roomId.ToString();
                            txtDeparture.Text = departureDate.ToString();
                            txtArrival.Text = arrivalDate.ToString();
                        }
                        else
                        {
                            MessageBox.Show("No booking details found with the selected booking ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }

            // Prepare confirmation message with booking details
            string confirmationMessage = $"Are you sure you want to delete the booking for {guestName} in Room {roomId} from {arrivalDate.ToShortDateString()} to {departureDate.ToShortDateString()}?";

            // Confirm deletion
            DialogResult result = MessageBox.Show(confirmationMessage, "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }

            // Proceed to delete the booking
            string deleteQuery = "DELETE FROM Booking WHERE Booking_ID = @bookingId";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand(deleteQuery, conn))
                {
                    command.Parameters.AddWithValue("@bookingId", selectedBookingId);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Update room status for the duration of the booking
                            UpdateRoomStatus(roomId, arrivalDate, departureDate, false);

                            MessageBox.Show("Booking has been successfully deleted.", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Reload the bookings list to reflect changes
                            LoadBookingData();

                            // Clear the form fields
                            //ClearBookingDeleteFields();

                            // Reset the selected booking ID and uncheck confirmation checkbox
                            selectedBookingId = -1;
                            cmbConfirm.Checked = false;
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the booking. Please try again.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while deleting the booking: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void bookingsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the click is on a valid row
            {
                DataGridViewRow row = bookingsDataGridView.Rows[e.RowIndex];

                // Ensure the necessary cell values are not null
                if (row.Cells["Booking_ID"].Value != null)
                {
                    selectedBookingId = Convert.ToInt32(row.Cells["Booking_ID"].Value);

                    // Clear text fields before populating with data
                    if (tabControl1.SelectedTab == tabPage2)
                    {
                        txtBookingID_Delete.Text = selectedBookingId.ToString();
                        txtGuestFName_Delete.Text = "";
                        txtGuestLName_Delete.Text = "";
                        txtRoomNr_Delete.Text = "";
                        txtArrival.Text = "";
                        txtDeparture.Text = "";

                        string guestQuery = @"
                    SELECT g.Guest_FName, g.Guest_LName 
                    FROM Guest g 
                    INNER JOIN Booking b ON g.Guest_ID = b.Guest_ID 
                    WHERE b.Booking_ID = @bookingId";

                        string bookingQuery = @"
                    SELECT b.Room_ID, b.Guest_Arrival, b.Guest_Departure 
                    FROM Booking b 
                    WHERE b.Booking_ID = @bookingId";

                        try
                        {
                            using (SqlConnection conn = new SqlConnection(connection))
                            {
                                conn.Open();

                                // Retrieve guest details
                                using (SqlCommand cmd = new SqlCommand(guestQuery, conn))
                                {
                                    cmd.Parameters.AddWithValue("@bookingId", selectedBookingId);

                                    using (SqlDataReader reader = cmd.ExecuteReader())
                                    {
                                        if (reader.Read())
                                        {
                                            txtGuestFName_Delete.Text = reader["Guest_FName"].ToString();
                                            txtGuestLName_Delete.Text = reader["Guest_LName"].ToString();
                                        }
                                        else
                                        {
                                            MessageBox.Show("No guest details found for the selected booking ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }

                                // Retrieve booking details
                                using (SqlCommand cmd = new SqlCommand(bookingQuery, conn))
                                {
                                    cmd.Parameters.AddWithValue("@bookingId", selectedBookingId);

                                    using (SqlDataReader reader = cmd.ExecuteReader())
                                    {
                                        if (reader.Read())
                                        {
                                            txtRoomNr_Delete.Text = reader["Room_ID"].ToString();
                                            if (reader["Guest_Arrival"] != DBNull.Value)
                                            {
                                                DateTime arrivalDate = Convert.ToDateTime(reader["Guest_Arrival"]);
                                                txtArrival.Text = arrivalDate.ToString("yyyy-MM-dd"); // Or another format
                                            }
                                            else
                                            {
                                                txtArrival.Text = "N/A"; // Or another default value
                                            }

                                            if (reader["Guest_Departure"] != DBNull.Value)
                                            {
                                                DateTime departureDate = Convert.ToDateTime(reader["Guest_Departure"]);
                                                txtDeparture.Text = departureDate.ToString("yyyy-MM-dd"); // Or another default value
                                            }
                                            else
                                            {
                                                txtDeparture.Text = "N/A"; // Or another default value
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("No booking details found for the selected booking ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show($"An error occurred while retrieving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (tabControl1.SelectedTab == tabPage1)
                    {
                        txtRoomNr_Update.Text = "";
                        dtArrival_Update.Value = DateTime.Now;
                        dtDeparture_Update.Value = DateTime.Now;

                        string bookingQuery = @"
                    SELECT b.Room_ID, b.Guest_Arrival, b.Guest_Departure 
                    FROM Booking b 
                    WHERE b.Booking_ID = @bookingId";

                        string guestQuery = @"
                    SELECT g.Guest_FName, g.Guest_LName 
                    FROM Guest g 
                    INNER JOIN Booking b ON g.Guest_ID = b.Guest_ID 
                    WHERE b.Booking_ID = @bookingId";

                        try
                        {
                            using (SqlConnection conn = new SqlConnection(connection))
                            {
                                conn.Open();

                                // Retrieve guest details
                                using (SqlCommand cmd = new SqlCommand(guestQuery, conn))
                                {
                                    cmd.Parameters.AddWithValue("@bookingId", selectedBookingId);

                                    using (SqlDataReader reader = cmd.ExecuteReader())
                                    {
                                        if (reader.Read())
                                        {
                                            txtGuestFName_Update.Text = reader["Guest_FName"].ToString();
                                            txtGuestLName_Update.Text = reader["Guest_LName"].ToString();
                                        }
                                        else
                                        {
                                            MessageBox.Show("No guest found with the selected booking ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }

                                // Retrieve booking details
                                using (SqlCommand cmd = new SqlCommand(bookingQuery, conn))
                                {
                                    cmd.Parameters.AddWithValue("@bookingId", selectedBookingId);

                                    using (SqlDataReader reader = cmd.ExecuteReader())
                                    {
                                        if (reader.Read())
                                        {
                                            txtBookingID_Update.Text = selectedBookingId.ToString();
                                            txtRoomNr_Update.Text = reader["Room_ID"].ToString();
                                            DateTime arrivalDate = Convert.ToDateTime(reader["Guest_Arrival"]);
                                            dtArrival_Update.Value = arrivalDate;
                                            DateTime departureDate = Convert.ToDateTime(reader["Guest_Departure"]);
                                            dtDeparture_Update.Value = departureDate;
                                        }
                                        else
                                        {
                                            MessageBox.Show("No booking details found for the selected booking ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show($"An error occurred while retrieving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No booking details found for the selected row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        private void ClearBookingDeleteFields()
        {
            // Clear all the fields in the deletion form
            txtBookingID_Delete.Clear();
            txtGuestFName_Delete.Clear();
            txtGuestLName_Delete.Clear();
            txtRoomNr_Delete.Clear();
            txtDeparture.Clear();
            txtArrival.Clear();
        }

        private void dtArrival_Update_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedCheckinDate = dtArrival_Update.Value.Date;
            DateTime currentDate = DateTime.Today;

            if (selectedCheckinDate < currentDate)
            {
                errorProvider1.SetError(dtCheckin, "The check-in date cannot be in the past. Please select a valid date.");
                // Optionally, reset the date picker to the current date
                dtCheckin.Value = currentDate;
            }
        }

        private void dtDeparture_Update_ValueChanged(object sender, EventArgs e)
        {
            int maxBookingDuration = 30;

            DateTime selectedCheckoutDate = dtDeparture_Update.Value.Date;
            DateTime selectedCheckinDate = dtArrival_Update.Value.Date;
            TimeSpan duration = selectedCheckoutDate - selectedCheckinDate;

            if (selectedCheckoutDate == selectedCheckinDate)
            {
                errorProvider1.SetError(dtCheckout, "Booking has to be for at least one day");
            }
            if (duration.Days > maxBookingDuration)
            {
                MessageBox.Show("The maximum booking duration is 30 days. Please select a shorter stay.");
            }
            if (selectedCheckoutDate < selectedCheckinDate)
            {
                MessageBox.Show("Departure date cannot be before Arrival date!");
            }
        }

        private void txtRoomNr_Update_TextChanged(object sender, EventArgs e)
        {
            if (!IsTextDigitsValid(txtRoomNr_Update.Text))
            {
                if (txtRoomNrAdd.Text == null)
                {
                    errorProvider1.SetError(txtRoomNrAdd, "Please add room number");
                }
                errorProvider1.SetError(txtRoomNrAdd, "Room number can only contain digits");
            }
            else
            {
                errorProvider1.SetError(txtRoomNrAdd, string.Empty);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void bttnSearch_Click(object sender, EventArgs e)
        {
           
        }

        
        private void txtBookingID_Search_TextChanged(object sender, EventArgs e)
        {
            searchCriteria = true;
        }
    }
    }
}
