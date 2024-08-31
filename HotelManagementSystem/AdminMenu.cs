using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HotelManagementSystem.LogIn;

namespace HotelManagementSystem
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Guests guests = new Guests();
            guests.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            employees.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MaintainRooms rooms = new MaintainRooms();
            rooms.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bookings bookings = new Bookings();
            bookings.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManageJobsForm manageJobs = new ManageJobsForm(true);
            manageJobs.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CheckIn checkIn = new CheckIn();
            checkIn.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CheckOut checkOut = new CheckOut();
            checkOut.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ReportsForm reports = new ReportsForm(true);
            reports.Show();
        }
    }
}
