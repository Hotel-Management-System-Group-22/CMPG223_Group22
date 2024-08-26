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
    public partial class Confirmation_Form : Form
    {
        public Confirmation_Form()
        {
            InitializeComponent();
        }

        private void Confirmation_Form_Load(object sender, EventArgs e)
        {
            public Confirmation_Form(string guestID, string name, string surname, string contactNumber, string email, DateTime arrivalDate, DateTime departureDate, string roomType)
            {
                InitializeComponent();

                // Populate the form fields with the data
                lblGuestID.Text = guestID;
                lblName.Text = name;
                lblSurname.Text = surname;
                lblContactNumber.Text = contactNumber;
                lblEmail.Text = email;
                lblArrivalDate.Text = arrivalDate.ToShortDateString();
                lblDepartureDate.Text = departureDate.ToShortDateString();
                lblRoomType.Text = roomType;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            New_Guests newGuestForm = new New_Guests();
            newGuestForm.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Code to save the guest information to the database or data structure

            MessageBox.Show("New guest added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            Booking_Menu mainMenuForm = new Booking_Menu();
            mainMenuForm.Show();
        }
    }
}
