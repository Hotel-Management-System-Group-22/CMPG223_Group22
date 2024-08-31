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
        private bool bAfrikaans = false;
        public Bookings()
        {
            InitializeComponent();
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);

            btnLanguage_Click(this, EventArgs.Empty);
            btnLanguage.PerformClick();
            btnLanguage_Click(this, EventArgs.Empty);
            btnLanguage.PerformClick();
        }
        string connection = "Data Source=CAITLIN\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True;";
        private void ValidateTextBox(System.Windows.Forms.TextBox textBox)
        {
            if (textBox != null)
            {
                string input = textBox.Text;
                {
                    if (!IsTextValid(input))
                    {
                        if (bAfrikaans == false)
                        {
                            errorProvider1.SetError(textBox, "Input must contain only letters and first letter must be capitilized.");
                        }
                        else
                        {
                            errorProvider1.SetError(textBox, "Invoer moet slegs letters bevat en die eerste letter moet gekapitaliseer word.");
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(textBox, string.Empty);
                    }
                }
            }
            else
            {
                if (bAfrikaans == false)
                {
                     errorProvider1.SetError(textBox, "Please fill the textbox");
                }
                else
                {
                     errorProvider1.SetError(textBox, "Vul asseblief die teksboks in");
                }
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

            //StackOverFLow TEST IF IT WORKS!!
            string updateStatusQuery = @"UPDATE Room SET Status = CASE WHEN @isBooked = 1 THEN 1 WHEN @departureDate = CAST(GETDATE() AS DATE) THEN 0 ELSE Status ENDWHERE Room_ID = @roomIdAND EXISTS (SELECT 1FROM BookingWHERE Room_ID = @roomIdAND Guest_Arrival <= @departureDateAND Guest_Departure >= @arrivalDate)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(updateStatusQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@isBooked", isBooked);
                        cmd.Parameters.AddWithValue("@roomId", roomId);
                        cmd.Parameters.AddWithValue("@arrivalDate", arrivalDate);
                        cmd.Parameters.AddWithValue("@departureDate", departureDate);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Optionally handle the result
                        if (rowsAffected == 0)
                        {
                            // Handle the case where no rows were updated
                            if (bAfrikaans == false)
                            {
                                Console.WriteLine("No matching room found or status was not updated.");
                            }
                            else
                            {
                                Console.WriteLine("Geen bypassende kamer gevind of status is nie opgedateer nie.");
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Log or handle the exception as needed
                if (bAfrikaans == false)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
                else
                {
                    Console.WriteLine($"'n Fout het voorgekom: {ex.Message}");
                }
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
                    if (bAfrikaans == false)
                    {
                        errorProvider1.SetError(txtRoomNrAdd, "Please add room number");
                    }
                    else
                    {
                        errorProvider1.SetError(txtRoomNrAdd, "Voeg asseblief kamernommer by");
                    }
                }
                if (bAfrikaans == false)
                {
                    errorProvider1.SetError(txtRoomNrAdd, "Room number can only contain digits");
                }
                else
                {
                    errorProvider1.SetError(txtRoomNrAdd, "Kamernommer kan slegs syfers bevat");
                }
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
                                if (bAfrikaans == false)
                                {
                                    guestId = Convert.ToInt32(reader["Guest_ID"]);
                                }
                                else
                                {
                                    guestId = Convert.ToInt32(reader["Gas_ID"]);
                                }
                            }
                            else
                            {
                                if (bAfrikaans == false)
                                {
                                    MessageBox.Show("Guest not found. Please add guest to system before completing booking");
                                    return;
                                }
                                else
                                {
                                    MessageBox.Show("Gas nie gevind nie. Voeg asseblief gas by stelsel voor jy bespreking voltooi");
                                    return;
                                }
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
                                if (bAfrikaans == false)
                                {
                                    MessageBox.Show("The selected room does not exist.");
                                    return;
                                }
                                else
                                {
                                    MessageBox.Show("Die geselekteerde kamer bestaan ​​nie.");
                                    return;
                                }
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
                                if (bAfrikaans == false)
                                {
                                    MessageBox.Show("Booking added successfully.");
                                    UpdateRoomStatus(roomId, arrivalDate, departureDate, true);
                                }
                                else
                                {
                                    MessageBox.Show("Bespreking is suksesvol bygevoeg.");
                                    UpdateRoomStatus(roomId, arrivalDate, departureDate, true);
                                }
                            }
                            else
                            {
                                if (bAfrikaans == false)
                                {
                                    MessageBox.Show("Failed to add booking.");
                                }
                                else
                                {
                                    MessageBox.Show("Kon nie bespreking byvoeg nie.");
                                }
                            }
                        }
                    }
                }
                LoadBookingData();
            }
            else
            {
                if (bAfrikaans == false)
                {
                    MessageBox.Show("Please ensure all errors are corrected");
                }
                else
                {
                    MessageBox.Show("Verseker asseblief dat alle foute reggestel word");
                }
            }

        }

        private void dtCheckin_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedCheckinDate = dtCheckin.Value.Date;
            DateTime currentDate = DateTime.Today;

            if (selectedCheckinDate < currentDate)
            {
                if (bAfrikaans == false)
                {
                    errorProvider1.SetError(dtCheckin, "The check-in date cannot be in the past. Please select a valid date.");
                }
                else
                {
                    errorProvider1.SetError(dtCheckin, "Die inklokdatum kan nie in die verlede wees nie. Kies asseblief 'n geldige datum.");
                }
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
                if (bAfrikaans == false)
                {
                    errorProvider1.SetError(dtCheckout, "Booking has to be for at least one day");
                }
                else
                {
                    errorProvider1.SetError(dtCheckout, "Bespreking moet vir ten minste een dag wees");
                }
            }
            if (duration.Days > maxBookingDuration)
            {
                if (bAfrikaans == false)
                {
                    MessageBox.Show("The maximum booking duration is 30 days. Please select a shorter stay.");
                }
                else
                {
                    MessageBox.Show("Die maksimum besprekingsduur is 30 dae. Kies asseblief 'n korter verblyf.");
                }
            }
            if (selectedCheckoutDate < selectedCheckinDate)
            {
                if (bAfrikaans == false)
                {
                    MessageBox.Show("Departure date cannot be before Arrival date!");
                }
                else
                {
                    MessageBox.Show("Vertrekdatum kan nie voor Aankomsdatum wees nie!");
                }
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
                    
                    if (bAfrikaans == false)
                    {
                        errorProvider1.SetError(txtRoomNrAdd, "Please add room number");
                    }
                    else
                    {
                        errorProvider1.SetError(txtRoomNrAdd, "Voeg asseblief kamernommer by");
                    }
                }
                if (bAfrikaans == false)
                {
                    errorProvider1.SetError(txtRoomNrAdd, "Room number can only contain digits");
                }
                else
                {
                    errorProvider1.SetError(txtRoomNrAdd, "Kamernommer kan slegs syfers bevat");
                }
                
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
            if (string.IsNullOrEmpty(errorProvider1.GetError(txtRoomNr_Update)) && string.IsNullOrEmpty(errorProvider1.GetError(dtArrival_Update)) && string.IsNullOrEmpty(errorProvider1.GetError(dtDeparture_Update)))
            {

                if (selectedBookingId == -1)
                {
                    if (bAfrikaans == false)
                    {
                        MessageBox.Show("No booking selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Geen bespreking gekies nie.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                int roomId;
                if (!int.TryParse(txtRoomNr_Update.Text, out roomId))
                {
                    if (bAfrikaans == false)
                    {
                        MessageBox.Show("Please enter a valid room number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Voer asseblief 'n geldige kamernommer in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                
                DateTime newArrivalDate = dtArrival_Update.Value;
                DateTime newDepartureDate = dtDeparture_Update.Value;


                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    string checkRoomExistenceQuery = "SELECT COUNT(*) FROM Room WHERE Room_ID = @roomId";

                    using (SqlCommand cmdExistence = new SqlCommand(checkRoomExistenceQuery, conn))
                    {
                        cmdExistence.Parameters.AddWithValue("@roomId", roomId);

                        int roomExists = Convert.ToInt32(cmdExistence.ExecuteScalar());
                        if (roomExists == 0)
                        {
                            if (bAfrikaans == false)
                            {
                                MessageBox.Show("The selected room does not exist.");
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Die geselekteerde kamer bestaan ​​nie.");
                                return;
                            }
                        }
                    }
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
                                if (bAfrikaans == false)
                                {
                                    MessageBox.Show("The room is already booked for those dates.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    transaction.Rollback();
                                    return;
                                }
                                else
                                {
                                    MessageBox.Show("Die kamer is reeds vir daardie datums bespreek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    transaction.Rollback();
                                    return;
                                }
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
                                if (bAfrikaans == false)
                                {
                                    MessageBox.Show("No booking was updated. Please check the booking ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    transaction.Rollback();
                                    return;
                                }
                                else
                                {
                                    MessageBox.Show("Geen bespreking is opgedateer nie. Kontroleer asseblief die bespreking-ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    transaction.Rollback();
                                    return;
                                }
                            }
                        }

                        // Commit the transaction if everything is okay
                        transaction.Commit();
                        if (bAfrikaans == false)
                        {
                            MessageBox.Show("Booking updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UpdateRoomStatus(roomId, newArrivalDate, newDepartureDate, true);
                            LoadBookingData(); // Refresh booking data
                        }
                        else
                        {
                            MessageBox.Show("Bespreking is suksesvol opgedateer.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UpdateRoomStatus(roomId, newArrivalDate, newDepartureDate, true);
                            LoadBookingData(); // Herlaai besprekingsdata
                        }
                    }
                    catch (Exception ex)
                    {
                        // Rollback the transaction if something went wrong
                        if (bAfrikaans == false)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Error updating booking: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            transaction.Rollback();
                            MessageBox.Show("Fout met die opdatering van bespreking: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else 
            {
                if (bAfrikaans == false)
                {
                    MessageBox.Show("Please complete all fields and ensure all errors are corrected");
                }
                else
                {
                    MessageBox.Show("Vul asseblief alle velde in en maak seker dat alle foute reggestel word");
                }
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
                            if (bAfrikaans == false)
                            {
                                MessageBox.Show("Guest not found for the selected booking ID. Please ensure the Booking ID is correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Gas nie gevind vir die gekose besprekings-ID nie. Maak asseblief seker dat die besprekings-ID korrek is.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
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
                            lblBooking.Text = reader["Booking_ID"].ToString();
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
                            if (bAfrikaans == false)
                            {
                                MessageBox.Show("Booking not found with the selected ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("Bespreking nie gevind met die geselekteerde ID nie.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
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
                if (bAfrikaans == false)
                {
                    MessageBox.Show("No booking selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Geen bespreking gekies nie.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Ensure the confirmation checkbox is checked
            if (!cmbConfirm.Checked)
            {
                if (bAfrikaans == false)
                {
                    MessageBox.Show("Please confirm that you want to delete this booking by checking the confirmation box.", "Confirmation Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    MessageBox.Show("Bevestig asseblief dat jy hierdie bespreking wil uitvee deur die bevestigingblokkie te merk.", "Bevestiging vereis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
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
                            if (bAfrikaans == false)
                            {
                                MessageBox.Show("No guest found with the selected booking ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Geen gas gevind met die gekose bespreking-ID nie.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
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
                            if (bAfrikaans == false)
                            {
                                MessageBox.Show("No booking details found with the selected booking ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Geen besprekingbesonderhede gevind met die gekose besprekings-ID nie.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }
            }

            string confirmationMessage = "";
            
            // Prepare confirmation message with booking details
            if (bAfrikaans == false)
            {
                confirmationMessage = $"Are you sure you want to delete the booking for {guestName} in Room {roomId} from {arrivalDate.ToShortDateString()} to {departureDate.ToShortDateString()}?";

            }
            else
            {
                confirmationMessage = $"Is jy seker jy wil die bespreking vir {guestName} in Kamer {roomId} van {arrivalDate.ToShortDateString()} na {departureDate.ToShortDateString()} uitvee?";
            }

            // Confirm deletion
            DialogResult result;
            if (bAfrikaans == false)
            {
                result = MessageBox.Show(confirmationMessage, "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            }
            else
            {
                result = MessageBox.Show(confirmationMessage, "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

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

                            if (bAfrikaans == false)
                            {
                                MessageBox.Show("Booking has been successfully deleted.", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                UpdateRoomStatus(roomId, arrivalDate, departureDate, false);

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
                                MessageBox.Show("Bespreking is suksesvol uitgevee.", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                UpdateRoomStatus(roomId, arrivalDate, departureDate, false);

                                // Reload the bookings list to reflect changes
                                LoadBookingData();

                                // Clear the form fields
                                //ClearBookingDeleteFields();

                                // Reset the selected booking ID and uncheck confirmation checkbox
                                selectedBookingId = -1;
                                cmbConfirm.Checked = false;
                            } 
                        }
                        else
                        {
                            if (bAfrikaans == false)
                            {
                                MessageBox.Show("Failed to delete the booking. Please try again.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                MessageBox.Show("Kon nie die bespreking uitvee nie. Probeer asseblief weer.", "Kon nie uitvee nie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        if (bAfrikaans == false)
                        {
                            MessageBox.Show("An error occurred while deleting the booking: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            MessageBox.Show("'n Fout het voorgekom tydens die verwydering van die bespreking: " + ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
                                            if (bAfrikaans == false)
                                            {
                                                MessageBox.Show("No guest details found for the selected booking ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                            }
                                            else
                                            {
                                                MessageBox.Show("Geen gasbesonderhede vir die geselekteerde besprekings-ID gevind nie.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
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
                                            if (bAfrikaans == false)
                                            {
                                                MessageBox.Show("No guest details found for the selected booking ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                            }
                                            else
                                            {
                                                MessageBox.Show("Geen gasbesonderhede vir die geselekteerde besprekings-ID gevind nie.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        catch (SqlException ex)
                        {
                            if (bAfrikaans == false)
                            {
                                MessageBox.Show($"An error occurred while retrieving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                MessageBox.Show($"'n Fout het voorgekom tydens die herwinning van data: {ex.Message}", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            if (bAfrikaans == false)
                            {
                                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                MessageBox.Show($"'n Onverwagte fout het voorgekom: {ex.Message}", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
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
                                            if (bAfrikaans == false)
                                            {
                                                MessageBox.Show("No guest details found for the selected booking ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                            }
                                            else
                                            {
                                                MessageBox.Show("Geen gasbesonderhede vir die geselekteerde besprekings-ID gevind nie.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
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
                                            if (bAfrikaans == false)
                                            {
                                                MessageBox.Show("No booking details found for the selected booking ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                            }
                                            else
                                            {
                                                MessageBox.Show("Geen besprekingbesonderhede vir die geselekteerde besprekings-ID gevind nie.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        catch (SqlException ex)
                        {
                            if (bAfrikaans == false)
                            {
                                MessageBox.Show($"An error occurred while retrieving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                MessageBox.Show($"'n Fout het voorgekom tydens die herwinning van data: {ex.Message}", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            if (bAfrikaans == false)
                            {
                                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                MessageBox.Show($"'n Onverwagte fout het voorgekom: {ex.Message}", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    if (bAfrikaans == false)
                    {
                        MessageBox.Show("No booking details found for the selected row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        MessageBox.Show("Geen besprekingsbesonderhede vir die geselekteerde ry gevind nie.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
                if (bAfrikaans == false)
                {
                    errorProvider1.SetError(dtArrival_Update, "The check-in date cannot be in the past. Please select a valid date.");
                }
                else
                {
                    errorProvider1.SetError(dtArrival_Update, "Die inklokdatum kan nie in die verlede wees nie. Kies asseblief 'n geldige datum.");
                }
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
                if (bAfrikaans == false)
                {
                    errorProvider1.SetError(dtCheckout, "Booking has to be for at least one day");
                }
                else
                {
                    errorProvider1.SetError(dtCheckout, "Bespreking moet vir ten minste een dag wees");
                }
            }
            if (duration.Days > maxBookingDuration)
            {
                if (bAfrikaans == false)
                {
                    MessageBox.Show("The maximum booking duration is 30 days. Please select a shorter stay.");
                }
                else
                {
                    MessageBox.Show("Die maksimum besprekingsduur is 30 dae. Kies asseblief 'n korter verblyf.");
                }
            }
            if (selectedCheckoutDate < selectedCheckinDate)
            {
                if (bAfrikaans == false)
                {
                    MessageBox.Show("Departure date cannot be before Arrival date!");
                }
                else
                {
                    MessageBox.Show("Vertrekdatum kan nie voor Aankomsdatum wees nie!");
                }
            }
        }

        private void txtRoomNr_Update_TextChanged(object sender, EventArgs e)
        {
            if (!IsTextDigitsValid(txtRoomNr_Update.Text))
            {
                if (bAfrikaans == false)
                {
                    errorProvider1.SetError(txtRoomNr_Update, "Room number can only contain digits");
                }
                else
                {
                    errorProvider1.SetError(txtRoomNr_Update, "Kamernommer kan slegs syfers bevat");
                }
            }
            else
            {
                errorProvider1.SetError(txtRoomNr_Update, string.Empty);
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
            DateTime arrivalDate = dateTimePicker1.Value;
            DateTime departureDate = dateTimePicker2.Value;

            string query = @"
        SELECT Room_ID, Room_Status 
        FROM Room 
        WHERE Room_ID NOT IN (
            SELECT Room_ID 
            FROM Booking 
            WHERE (@arrivalDate <= Guest_Departure AND @departureDate >= Guest_Arrival)
        )";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@arrivalDate", arrivalDate);
                    cmd.Parameters.AddWithValue("@departureDate", departureDate);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    bookingsDataGridView.DataSource = dt;
                }
            }

        }


        private void txtBookingID_Search_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtBookingID_Search.Text.Trim();
            FilterDataGridView(searchValue);
        }

        private void FilterDataGridView(string searchValue)
        {
            string query = @"SELECT * FROM Booking
                     WHERE Booking_ID LIKE @searchValue
                     ORDER BY Booking_ID ASC";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@searchValue", "%" + searchValue + "%");

                    DataTable dt = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }

                    if (dt.Rows.Count == 0)
                    {
                        // Show a message if no records are found
                        if (bAfrikaans == false)
                        {
                            MessageBox.Show("No bookings found for the given Booking ID.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Geen besprekings gevind vir die gegewe besprekings-ID nie.", "Geen resultate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    bookingsDataGridView.DataSource = dt;
                }
            }
        }


        private void btnSearchReset_Click(object sender, EventArgs e)
        {
           
        }

       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

       
        private void FilterDataGridViewByGuestFName(string searchValue)
        {
            // Ensure that the DataGridView has the correct column
            string columnName = "Guest_FName"; // Replace with the actual column name if different

            // Check if the column exists in the DataGridView
            if (!bookingsDataGridView.Columns.Contains(columnName))
            {
                if (bAfrikaans == false)
                {
                    MessageBox.Show($"Column '{columnName}' not found in DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show($"Kolom '{columnName}' nie in DataGridView gevind nie.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Filter the rows based on the search value
            foreach (DataGridViewRow row in bookingsDataGridView.Rows)
            {
                // Skip the new row if it's not committed yet
                if (row.IsNewRow)
                {
                    continue;
                }

                if (row.Cells[columnName].Value != null)
                {
                    string cellValue = row.Cells[columnName].Value.ToString();
                    row.Visible = cellValue.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void btnSearchReset_Click_1(object sender, EventArgs e)
        {
            LoadBookingData();
            txtBookingID_Search.Text = " ";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Guest";

            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        bookingsDataGridView.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                if (bAfrikaans == false)
                {
                    MessageBox.Show("Error loading guest data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Fout met die laai van gasdata: " + ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtGuestId_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Guest WHERE Guest_ID LIKE @GuestId";

            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn))
                    {
                        dataAdapter.SelectCommand.Parameters.AddWithValue("@GuestId", "%" + txtGuestId.Text + "%");

                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        bookingsDataGridView.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                if (bAfrikaans == false)
                {
                    MessageBox.Show("Error loading guest data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Fout met die laai van gasdata: " + ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            bAfrikaans = !bAfrikaans;

            if (bAfrikaans)
            {
                btnSearch.Text = "SOEK";
                btnAdd.Text = "VOEG TOE";
                btnUpdate.Text = "OPDATERING";
                btnDelete.Text = "VEE";
                btnLanguage.Text = "TAAL";
                gpGeneralSearch.Text = "Algemene soektog";
                lblBookingID.Text = "Soek volgens besprekings-ID:";
                gpGuestSearch.Text = "Algemene soektog";
                btnDisplayGuests.Text = "VERTOON ALLE GASTE";
                lblGuestID.Text = "Soek volgens gas-ID:";
                gpAvailablity.Text = "Soek vir beskikbare kamers vir tydperk";
                btnSearchReset.Text = "STEL TERUG";
                lblFName.Text = "Gas voornaam:";
                lblLName.Text = "Gas Van:";
                lblRoomNumber.Text = "Kamernommer:";
                lblArrivalDate.Text = "Aankomsdatum:";
                lblDepartureDate.Text = "Vertrekdatum:";
                btnAddReset.Text = "TERUGSTEL";
                btnAddBooking.Text = "VOEG TOE";
                gpVerifyBooking.Text = "Verifieer besprekingsbesonderhede";
                lblBooking.Text = "Besprekings-ID:";
                lblName.Text = "Gas voornaam:";
                lblSurname.Text = "Gas Van:";
                lblRoom.Text = "Kamernommer:";
                lblArrival.Text = "Aankomsdatum:";
                lblDeparture.Text = "Vertrekdatum:";
                cmbConfirm.Text = "Bevestig dat besonderhede wat uitgevee moet word korrek is";
                btnDeleteReset.Text = "TERUGSTEL";
                btnDeleteEmp.Text = "VEE UIT";
                gpBookingDetails.Text = "Besprekingsbesonderhede moet opgedateer word";
                lblIDBooking.Text = "Besprekings-ID:";
                lblGFName.Text = "Gas voornaam:";
                lblGLName.Text = "Gas Van:";
                lblGRoomNumber.Text = "Kamernommer:";
                lblGArrival.Text = "Aankomsdatum:";
                lblGDeparture.Text = "Vertrekdatum:";
                btnUpdateReset.Text = "TERUGSTEL";
                btnUpdateEmp.Text = "OPDATERING";
            }
            else
            {
                btnSearch.Text = "SEARCH";
                btnAdd.Text = "ADD";
                btnUpdate.Text = "UPDATE";
                btnDelete.Text = "DELETE";
                btnLanguage.Text = "LANGUAGE";
                gpGeneralSearch.Text = "General Search";
                lblBookingID.Text = "Search by Booking ID:";
                gpGuestSearch.Text = "General Search";
                btnDisplayGuests.Text = "DISPLAY ALL GUESTS";
                lblGuestID.Text = "Search by Guest ID:";
                gpAvailablity.Text = "Searchfor Avalible rooms for time period";
                btnSearchReset.Text = "RESET";
                lblFName.Text = "Guest First Name:";
                lblLName.Text = "Guest Last Name:";
                lblRoomNumber.Text = "Room number:";
                lblArrivalDate.Text = "Arrival Date:";
                lblDepartureDate.Text = "Departure Date:";
                btnAddReset.Text = "RESET";
                btnAddBooking.Text = "ADD";
                gpVerifyBooking.Text = "Verify Booking Details";
                lblBooking.Text = "BookingID:";
                lblName.Text = "Guest First Name:";
                lblSurname.Text = "Guest Last Name:";
                lblRoom.Text = "Room Number:";
                lblArrival.Text = "Arrival Date:";
                lblDeparture.Text = "Departure Date:";
                cmbConfirm.Text = "Confirm that details to be deleted are correct";
                btnDeleteReset.Text = "RESET";
                btnDeleteEmp.Text = "DELETE";
                gpBookingDetails.Text = "Booking Details to be Updated";
                lblIDBooking.Text = "Booking ID:";
                lblGFName.Text = "Guest First Name:";
                lblGLName.Text = "Guest Last Name:";
                lblGRoomNumber.Text = "Room Number:";
                lblGArrival.Text = "Arrival Date:";
                lblGDeparture.Text = "Departure Date:";
                btnUpdateReset.Text = "RESET";
                btnUpdateEmp.Text = "UPDATE";
            }
        }
    }
}
