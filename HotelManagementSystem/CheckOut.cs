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
    public partial class CheckOut : Form
    {
        public CheckOut()
        {
            InitializeComponent();
        }

        private void btnCheckOutCancel_Click(object sender, EventArgs e)
        {
            txtCheckOutBookingID.Text = string.Empty;
            txtCheckOutGuestID.Text = string.Empty;
            txtCheckOutRoomID.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}
