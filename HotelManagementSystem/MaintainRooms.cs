using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        string connection = "";


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
        private void LoadData()
        {
            string query = "SELECT * FROM Room";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbDescending_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDescending.Checked)
            {
                rdbAscending.Checked = false;
            }
            
        }

        private void rdbAscending_CheckedChanged(object sender, EventArgs e)
        {
            
            if (rdbAscending.Checked)
            {
                rdbDescending.Checked = false;
            }
        }

        private void btnSearchReset_Click(object sender, EventArgs e)
        {
            txtSearchRoom.Text = string.Empty;
        }

        private void btnAddReset_Click(object sender, EventArgs e)
        {
            txtRoomID.Text = string.Empty;  
            txtRoomNumber.Text = string.Empty;  
            nrudRoomRate.Value = 0;
            //cbxOccupancy.SelectedIndex = 0;
           // cbxRoomStatus.SelectedIndex = 0;
            //cbxRoomType.SelectedIndex = 0;
        }

        private void btnDeleteReset_Click(object sender, EventArgs e)
        {
            txtDeleteRoomID.Text = string.Empty;    
        }
    }
}
