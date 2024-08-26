using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.EntityFrameworkCore;
using static HotelManagementSystem.UpdateInformation;

namespace HotelManagementSystem
{
    public partial class Check_InConfirmation : Form
    {
        private Guest currentGuest;

        public Check_InConfirmation(Guest guest)
        {
            InitializeComponent();
            currentGuest = guest;
            PopulateGuestInformation();
        }

        private void PopulateGuestInformation()
        {
            txtName.Text = currentGuest.Name;
            txtSurname.Text = currentGuest.Surname;
            txtEmail.Text = currentGuest.EmailAddress;
            txtGuestID.Text = currentGuest.GuestID;
            txtRoomType.Text = GetRoomType(currentGuest.RoomID);
            txtRoomID.Text = currentGuest.RoomID;
            dtpCheckIn.Value = currentGuest.ArrivalDate;
            dtpCheckOut.Value = currentGuest.DepartureDate;
        }
        private string GetRoomType(string roomID)
        {
            if (roomID.StartsWith("S")) return "Standard";
            if (roomID.StartsWith("B")) return "Bachelor";
            if (roomID.StartsWith("D")) return "Deluxe";
            if (roomID.StartsWith("P")) return "Penthouse";
            return "Unknown";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Open the update form with the current guest information
            UpdateInformation updateGuestForm = new UpdateInformation(currentGuest);
            this.Hide();
            updateGuestForm.ShowDialog();

            // Refresh the confirmation form with updated information
            PopulateGuestInformation();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            currentGuest.ArrivalDate = dtpCheckIn.Value;
            currentGuest.DepartureDate = dtpCheckOut.Value;

            using(var context = new YourDbContext())
            {
                var guestToUpdate = context.Guests.FirstOrDefault(g => g.GuestID == currentGuest.GuestID);

                if (guestToUpdate != null)
                {
                    // Update the properties of the guest
                    guestToUpdate.Name = currentGuest.Name;
                    guestToUpdate.Surname = currentGuest.Surname;
                    guestToUpdate.Email = currentGuest.EmailAddress;
                    guestToUpdate.RoomID = currentGuest.RoomID;
                    guestToUpdate.CheckInDate = currentGuest.ArrivalDate;
                    guestToUpdate.CheckOutDate = currentGuest.DepartureDate;

                    // Save changes to the database
                    context.SaveChanges();
                }
            }

            MessageBox.Show("Guest checked in successfully!");

            // Return to the main menu or booking menu
            this.Hide();
            var menuForm = new Booking_Menu();
            menuForm.Show();
        }
    }
}

