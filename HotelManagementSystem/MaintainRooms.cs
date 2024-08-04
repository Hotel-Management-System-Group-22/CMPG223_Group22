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
    public partial class MaintainRooms : Form
    {
        public MaintainRooms()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            btnUpdateRoom.Visible = false;
            btnAddRoom.Visible = true;
            txtRoomID.Visible = false;
            lblRoomID.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            txtRoomID.Visible = true;
            lblRoomID.Visible = true;
            btnUpdateRoom.Visible = true;
            btnAddRoom.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
