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
    //New Guest = rbNewGuest
    //Update Information = rbUpdate
    //Check-In = rbCheckIn
    //Check-Out = rbCheckOut
    //Back = btnBack
    //Next = btnNext
    public partial class Booking_Menu : Form
    {
        public Booking_Menu()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rbNewGuest.Checked)
            {
                // Open the New Guest Form
                New_Guests newGuestForm = new New_Guests();
                newGuestForm.Show(); // Show the new form
                this.Hide(); // Hide the current form
            }
            else if (rbUpdate.Checked)
            {
                // Open the Update Information Form
                UpdateInformationForm updateInformationForm = new UpdateInformationForm();
                updateInformationForm.Show();
                this.Hide();
            }
            else if (rbCheckIn.Checked)
            {
                // Open the Check-In Form
                CheckInForm checkInForm = new CheckInForm();
                checkInForm.Show();
                this.Hide();
            }
            else if (rbCheckOut.Checked)
            {
                // Open the Check-Out Form
                CheckOutForm checkOutForm = new CheckOutForm();
                checkOutForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select an option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
