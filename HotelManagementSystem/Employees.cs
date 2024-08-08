using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelManagementSystem
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelManagementSystemDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.hotelManagementSystemDataSet.Employee);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAddFName.Clear();
            txtAddLName.Clear();
            cmbAddJob.Items.Clear();
            cmbAddRole.Items.Clear();  
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tabPage3.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tabPage1.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tabPage2.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateReset_Click(object sender, EventArgs e)
        {
            txtUpdateFName.Clear();
            txtUpdateLName.Clear();
            //cmbUpdateJob.SelectedIndex = 0;
            cmbUpdateRole.SelectedIndex = -1;

        }

        private void btnDeleteReset_Click(object sender, EventArgs e)
        {
            txtDeleteSerach.Clear();
        }

        private void btnSearchReset_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelManagementSystemDataSet);

        }
    }
}
