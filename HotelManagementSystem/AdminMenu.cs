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
        bool isAfrikaans = false;
        public AdminMenu(bool isAfrikaans)
        {
            InitializeComponent();
            this.isAfrikaans=isAfrikaans;
            checkLanguage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Guests guests = new Guests(isAfrikaans);
            guests.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees(isAfrikaans);
            employees.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MaintainRooms rooms = new MaintainRooms(isAfrikaans);
            rooms.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bookings bookings = new Bookings(isAfrikaans);
            bookings.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManageJobsForm manageJobs = new ManageJobsForm(true);
            manageJobs.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CheckIn checkIn = new CheckIn(isAfrikaans);
            checkIn.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CheckOut checkOut = new CheckOut(isAfrikaans);
            checkOut.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ReportsForm reports = new ReportsForm(true);
            reports.Show();
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
                btnEmployees.Text = "Handhaaf Werknemers";
                btnJobs.Text = "Handhaaf Poste";
                btnReports.Text = "Versoek Verslae";
            }
            else {
                btnBookings.Text = "Maintain Bookings";
                btnCheckIn.Text = "Check Guest in";
                btnCheckOut.Text = "Check Guest out";
                btnGuests.Text = "Maintain Guests";
                btnLanguage.Text = "Afrikaans";
                btnRooms.Text = "Maintain Rooms";
                btnEmployees.Text = "Maintain Employees";
                btnJobs.Text = "Maintain Jobs";
                btnReports.Text = "Request Reports";
            }
        }
    }
}
