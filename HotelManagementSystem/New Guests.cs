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
    //Back = btnBack
    //Next = btnNext
    //Name = txtName
    //Surname = txtSurname
    //Contact no. = txtContactNumber
    //Email = txtEmail
    //Arrival = dtpArrivalDate
    //Departure = dtpDepartureDate
    //GroupBox = grpRoomType
    //Standard = rbStandard
    //Bachelor = rbBachelor
    //Deluxe = rbDeluxe
    //Penthouse = rbPenthouse
    public partial class New_Guests : Form
    {
        public New_Guests()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            Booking_Menu mainMenuForm = new Booking_Menu(); // Create an instance of the Main Menu form
            mainMenuForm.Show(); // Show the Main Menu form
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Validate input fields (you can add more detailed validation as needed)
            if (string.IsNullOrEmpty(txtName.Text) ||
                string.IsNullOrEmpty(txtSurname.Text) ||
                string.IsNullOrEmpty(txtContactNumber.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                !rbStandard.Checked && !rbBachelor.Checked && !rbDeluxe.Checked && !rbPenthouse.Checked)
            {
                MessageBox.Show("Please fill in all required fields and select a room type.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Generate Guest ID (first letter of name + first letter of surname + 3 random digits)
            string guestID = txtName.Text[0].ToString().ToUpper() +
                             txtSurname.Text[0].ToString().ToUpper() +
                             new Random().Next(100, 999).ToString();

            // Store the collected data and generated IDs in variables or pass them to the next form
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string contactNumber = txtContactNumber.Text;
            string email = txtEmail.Text;
            DateTime arrivalDate = dtpArrivalDate.Value;
            DateTime departureDate = dtpDepartureDate.Value;
            string roomType = rbStandard.Checked ? "Standard" :
                              rbBachelor.Checked ? "Bachelor" :
                              rbDeluxe.Checked ? "Deluxe" : "Penthouse";

            // Open the ConfirmationForm and pass the collected data
            Confirmation_Form confirmationForm = new Confirmation_Form(
                guestID, name, surname, contactNumber, email, arrivalDate, departureDate, roomType);
            confirmationForm.Show();
            this.Hide();
        }
    }
}
