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
    public partial class Check_Out : Form
    {
        public Check_Out()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Navigate back to the Booking Menu
            this.Hide();
            var bookingMenu = new Booking_Menu(); // Replace with the actual form name if different
            bookingMenu.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string guestName = txtName.Text.Trim();
            string guestSurname = txtSurname.Text.Trim();

            if (string.IsNullOrEmpty(guestName) || string.IsNullOrEmpty(guestSurname))
            {
                MessageBox.Show("Please enter both Name and Surname.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new YourDbContext()) // Replace with your actual DbContext class name
            {
                // Find the guest by Name and Surname
                var guest = context.Guests.FirstOrDefault(g => g.Name == guestName && g.Surname == guestSurname);

                if (guest != null)
                {
                    // Navigate to the Check-Out Confirmation form
                    this.Hide();
                    var checkOutConfirmation = new Check_OutConfirmation(guest); // Pass the guest information to the next form
                    checkOutConfirmation.Show();
                }
                else
                {
                    MessageBox.Show("Guest not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
