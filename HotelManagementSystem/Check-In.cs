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

namespace HotelManagementSystem
{
    public partial class Check_In : Form
    {
        public Check_In()
        {
            InitializeComponent();
        }

        private void lblGuestID_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string guestName = txtName.Text;
            string guestSurname = txtSurname.Text;

            // Fetch the guest by name and surname
            Guest guest = GetGuestByNameAndSurname(guestName, guestSurname);

            if (guest == null)
            {
                MessageBox.Show("Guest not found.");
                return;
            }

            // Proceed to the Confirmation Form with the guest's information
            Check_InConfirmation confirmationForm = new Check_InConfirmation(guest);
            this.Hide();
            confirmationForm.Show();
        }

        private Guest GetGuestByNameAndSurname(string name, string surname)
        {
            using (var context = new HotelDbContext())
            {
                return context.Guests.FirstOrDefault(g => g.Name == name && g.Surname == surname);
            }
        }

    }
}
