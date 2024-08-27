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
            string updateStatusQuery = @"UPDATE RoomSET Status = @statusWHERE Room_ID = @roomId AND EXISTS (SELECT 1 FROM Booking WHERE Room_ID = @roomId AND Guest_Arrival <= @departureDate AND Guest_Departure >= @arrivalDat)";
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            using (SqlCommand cmd = new SqlCommand(updateStatusQuery, conn))
            {
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@roomId", roomId);
                cmd.Parameters.AddWithValue("@arrivalDate", arrivalDate);
                cmd.Parameters.AddWithValue("@departureDate", departureDate);

                cmd.ExecuteNonQuery();
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

            
            if (string.IsNullOrEmpty(errorProvider1.GetError(txtGuestFNameAdd)) && string.IsNullOrEmpty(errorProvider1.GetError(txtGuestLNameAdd)) && string.IsNullOrEmpty(errorProvider1.GetError(txtRoomNrAdd)) && string.IsNullOrEmpty(errorProvider1.GetError(dtCheckin)) && string.IsNullOrEmpty(errorProvider1.GetError(dtCheckout))){

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
                errorProvider1.SetError(dtCheckin,"The check-in date cannot be in the past. Please select a valid date.");
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
                errorProvider1.SetError(dtCheckout,"Booking has to be for at least one day");
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

        }
        private bool UpdateBooking(int bookingId, int roomId, DateTime newArrivalDate, DateTime newDepartureDate)
        {
            // Check if new dates are valid
            if (newArrivalDate >= newDepartureDate)
            {
                MessageBox.Show("The departure date must be after the arrival date.");
                return false;
            }

            if ((newDepartureDate - newArrivalDate).Days > 30)
            {
                MessageBox.Show("The maximum booking duration is 30 days.");
                return false;
            }

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Check for overlapping bookings
                    string checkOverlapQuery = @"SELECT COUNT(*)FROM Booking WHERE Room_ID = @roomIdAND Booking_ID != @bookingId AND (Guest_Arrival <= @newDepartureDate AND Guest_Departure >= @newArrivalDate)";

                    using (SqlCommand cmdCheckOverlap = new SqlCommand(checkOverlapQuery, conn, transaction))
                    {
                        cmdCheckOverlap.Parameters.AddWithValue("@roomId", roomId);
                        cmdCheckOverlap.Parameters.AddWithValue("@bookingId", bookingId);
                        cmdCheckOverlap.Parameters.AddWithValue("@newArrivalDate", newArrivalDate);
                        cmdCheckOverlap.Parameters.AddWithValue("@newDepartureDate", newDepartureDate);

                        int overlapCount = Convert.ToInt32(cmdCheckOverlap.ExecuteScalar());
                        if (overlapCount > 0)
                        {
                            MessageBox.Show("The room is already booked for those dates.");
                            transaction.Rollback();
                            return false;
                        }
                    }

                    // Update the booking with new dates
                    string updateBookingQuery = @"UPDATE BookingSET Guest_Arrival = @newArrivalDate,Guest_Departure = @newDepartureDateWHERE Booking_ID = @bookingId";

                    using (SqlCommand cmdUpdateBooking = new SqlCommand(updateBookingQuery, conn, transaction))
                    {
                        cmdUpdateBooking.Parameters.AddWithValue("@newArrivalDate", newArrivalDate);
                        cmdUpdateBooking.Parameters.AddWithValue("@newDepartureDate", newDepartureDate);
                        cmdUpdateBooking.Parameters.AddWithValue("@bookingId", bookingId);

                        cmdUpdateBooking.ExecuteNonQuery();
                    }

                    // Commit the transaction if everything is okay
                    transaction.Commit();
                    MessageBox.Show("Booking updated successfully.");
                    return true;
                }
                catch (Exception ex)
                {
                    // Rollback the transaction if something went wrong
                    transaction.Rollback();
                    MessageBox.Show("Error updating booking: " + ex.Message);
                    return false;
                }
            }
        }

        private void Bookings_Load(object sender, EventArgs e)
        {
            LoadBookingData();
        }
    }
}
