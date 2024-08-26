using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HotelManagementSystem.UpdateInformation;
using System.Xml.Linq;

namespace HotelManagementSystem
{
    public partial class Check_OutConfirmation : Form
    {
        private Guest currentGuest;

        public Check_OutConfirmation(Guest guest)
        {
            InitializeComponent();
            currentGuest = guest;
            PopulateGuestInformation();
        }

        private void PopulateGuestInformation()
        {
            txtBookingID.Text = currentGuest.BookingID; // Assuming you have this field in your Guest model
            txtName.Text = currentGuest.Name;
            txtSurname.Text = currentGuest.Surname;
            txtContactNumber.Text = currentGuest.ContactNumber;
            txtEmail.Text = currentGuest.EmailAddress;
            txtGuestID.Text = currentGuest.GuestID;
            txtRoomType.Text = GetRoomType(currentGuest.RoomID);
            txtRoomID.Text = currentGuest.RoomID;
            dtpArrivalDate.Value = currentGuest.ArrivalDate;
            dtpDepartureDate.Value = currentGuest.DepartureDate;
        }

        private string GetRoomType(string roomID)
        {
            if (roomID.StartsWith("S")) return "Standard";
            if (roomID.StartsWith("B")) return "Bachelor";
            if (roomID.StartsWith("D")) return "Deluxe";
            if (roomID.StartsWith("P")) return "Penthouse";
            return "Unknown";
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblContactNumber_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var checkOutForm = new Check_Out(); // Replace with the actual Check-Out form name if different
            checkOutForm.Show();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            using (var context = new YourDbContext()) // Replace with your actual DbContext class name
            {
                var guestToCheckOut = context.Guests.FirstOrDefault(g => g.GuestID == currentGuest.GuestID);

                if (guestToCheckOut != null)
                {
                    // Update the guest's check-out status or remove the guest from the database if necessary
                    guestToCheckOut.CheckOutDate = DateTime.Now; // Update the check-out date

                    context.SaveChanges();

                    MessageBox.Show("Guest checked out successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Optionally, navigate back to the Booking Menu or another form
                    this.Hide();
                    var bookingMenu = new Booking_Menu(); // Replace with the actual Booking Menu form name if different
                    bookingMenu.Show();
                }
                else
                {
                    MessageBox.Show("Guest not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
