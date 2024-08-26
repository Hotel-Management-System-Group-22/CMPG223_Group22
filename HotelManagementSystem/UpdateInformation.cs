using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class UpdateInformation : Form
    {
        private Guest currentGuest;

        // Constructor that takes a Guest object as a parameter
        public UpdateInformation(Guest guest)
        {
            InitializeComponent();
            currentGuest = guest;

            // Populate the form with the guest's information
            txtName.Text = currentGuest.Name;
            txtSurname.Text = currentGuest.Surname;
            txtEmail.Text = currentGuest.EmailAddress;
            txtRoomID.Text = currentGuest.RoomID;
            dtpArrivalDate.Value = currentGuest.ArrivalDate;
            dtpDepartureDate.Value = currentGuest.DepartureDate;
        }

        private void lblContactNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Assuming you have a method GetGuestByID that fetches the guest from your data source
            string guestID = txtGuestID.Text.Trim();

            if (string.IsNullOrEmpty(guestID))
            {
                MessageBox.Show("Please enter a valid Guest ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            using(var context = new YourDBContext())
            {
                Guest guest = GetGuestByID(guestID); // Replace this with your actual data fetching logic

                if (guest != null)
                {
                    // Populate the form fields with the guest's information
                    txtName.Text = guest.Name;
                    txtSurname.Text = guest.Surname;
                    txtContactNumber.Text = guest.ContactNumber;
                    txtEmail.Text = guest.EmailAddress;
                    dtpArrivalDate.Value = guest.ArrivalDate;
                    dtpDepartureDate.Value = guest.DepartureDate;
                    txtRoomID.Text = guest.RoomID;

                    // Set the room type radio button based on the guest's current room type
                    switch (guest.RoomType)
                    {
                        case "Standard":
                            rbStandard.Checked = true;
                            break;
                        case "Bachelor":
                            rbBachelor.Checked = true;
                            break;
                        case "Deluxe":
                            rbDeluxe.Checked = true;
                            break;
                        case "Penthouse":
                            rbPenthouse.Checked = true;
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Guest not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            

        }

        // Example list of guests for demonstration purposes
        private List<Guest> guestList = new List<Guest>
        {
            new Guest { GuestID = "AB123", Name = "John", Surname = "Doe", ContactNumber = "1234567890" },
            new Guest { GuestID = "CD456", Name = "Jane", Surname = "Smith", ContactNumber = "0987654321" }
        };

        private Guest GetGuestByID(string guestID)
        {
            using (var context = new YourDbContext()) // Replace with your actual DbContext
            {
                return context.Guests.FirstOrDefault(g => g.GuestID == guestID);
            }
        }
        // Example method to fetch guest by ID - replace with actual implementation
        private Guest GetGuestByID(string guestID, List<Guest> guestList)
        {
            return guestList.FirstOrDefault(g => g.GuestID == guestID);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string guestID = txtGuestID.Text.Trim();

                // Fetch the guest by ID (assume GetGuestByID is implemented as above)
                Guest guest = GetGuestByID(guestID);

                if (guest != null)
                {
                    // Update the guest's information
                    guest.Name = txtName.Text.Trim();
                    guest.Surname = txtSurname.Text.Trim();
                    guest.ContactNumber = txtContactNumber.Text.Trim();
                    guest.EmailAddress = txtEmail.Text.Trim();
                    guest.ArrivalDate = dtpArrivalDate.Value;
                    guest.DepartureDate = dtpDepartureDate.Value;
                    guest.RoomID = txtRoomID.Text.Trim();

                    // Update the room type
                    if (rbStandard.Checked)
                        guest.RoomType = "Standard";
                    else if (rbBachelor.Checked)
                        guest.RoomType = "Bachelor";
                    else if (rbDeluxe.Checked)
                        guest.RoomType = "Deluxe";
                    else if (rbPenthouse.Checked)
                        guest.RoomType = "Penthouse";

                    // Save the changes - assume SaveGuestChanges is implemented
                    SaveGuestChanges(guest);

                    MessageBox.Show("Guest information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Guest not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()) ||
                string.IsNullOrEmpty(txtSurname.Text.Trim()) ||
                string.IsNullOrEmpty(txtContactNumber.Text.Trim()) ||
                string.IsNullOrEmpty(txtEmail.Text.Trim()) ||
                (!rbStandard.Checked && !rbBachelor.Checked && !rbDeluxe.Checked && !rbPenthouse.Checked))
            {
                MessageBox.Show("Please fill out all fields and select a room type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        // Example method to save guest changes - replace with actual implementation
        private void SaveGuestChanges(Guest guest)
        {
            // Update the guest in your data source (e.g., database, list, etc.)
            // Replace this with your actual data access logic
        }

        public class Guest
        {
            public string GuestID { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string ContactNumber { get; set; }
            public string EmailAddress { get; set; }
            public string RoomID { get; set; }
            public DateTime ArrivalDate { get; set; }
            public DateTime DepartureDate { get; set; }
            public string RoomType { get; set; }
        }
    }
}
