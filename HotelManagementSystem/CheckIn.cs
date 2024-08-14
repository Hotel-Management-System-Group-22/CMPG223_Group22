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
    public partial class CheckIn : Form
    {
        public CheckIn()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtRoomID.Text = string.Empty;
            txtGuestID.Text = string.Empty;
            txtBookingID.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}
