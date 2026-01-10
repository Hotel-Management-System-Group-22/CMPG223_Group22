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
    public partial class ClerkMenu : Form
    {
        bool isAfrikaans = false;
        public ClerkMenu(bool isAfrikaans)
        {
            InitializeComponent();
            this.isAfrikaans=isAfrikaans;
            checkLanguage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Guests guests = new Guests(isAfrikaans);
            guests.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MaintainRooms maintainRooms = new MaintainRooms(isAfrikaans);
            maintainRooms.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bookings bookings = new Bookings(isAfrikaans);
            bookings.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CheckIn checkIn = new CheckIn(isAfrikaans);
            checkIn.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CheckOut checkOut = new CheckOut(isAfrikaans);
            checkOut.Show();
            this.Hide();
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            if (isAfrikaans)
            {
                isAfrikaans = false;
            }
            else {
                isAfrikaans = true;
            }
            checkLanguage();
        }

        private void checkLanguage() {
            if (isAfrikaans)
            {
                btnBookings.Text = "Handhaaf Besprekings";
                btnCheckIn.Text = "Gaste Inboek";
                btnCheckOut.Text = "Gaste Uitboek";
                btnGuests.Text = "Handhaaf Gaste";
                btnLanguage.Text = "English";
                btnRooms.Text = "Handhaaf Kamers";
            }
            else
            {
                btnBookings.Text = "Maintain Bookings";
                btnCheckIn.Text = "Check Guest in";
                btnCheckOut.Text = "Check Guest out";
                btnGuests.Text = "Maintain Guests";
                btnLanguage.Text = "Afrikaans";
                btnRooms.Text = "Maintain Rooms";
            }
        }
    }
}
