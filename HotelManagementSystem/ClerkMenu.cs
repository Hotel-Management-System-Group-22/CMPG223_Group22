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
        public ClerkMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Guests guests = new Guests();
            guests.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MaintainRooms maintainRooms = new MaintainRooms();
            maintainRooms.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bookings bookings = new Bookings();
            bookings.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CheckIn checkIn = new CheckIn();
            checkIn.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CheckOut checkOut = new CheckOut();
            checkOut.Show();
        }
    }
}
