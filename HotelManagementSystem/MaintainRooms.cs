using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace HotelManagementSystem
{
    public partial class MaintainRooms : Form
    {
        public MaintainRooms()
        {
            InitializeComponent();

            btnAddReset.Click += new EventHandler(btnAddReset_Click);
            btnDeleteReset.Click += new EventHandler(btnDeleteReset_Click);
            btnSearchReset.Click += new EventHandler(btnDeleteReset_Click);
        }

        string connection = "Data Source=(Localdb)\\MSSQLLocalDB;Database=Cmpg223;Trusted_Connection=True;";
        int selectedId;



        private void btnSearch_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            btnSearchReset_Click(this, EventArgs.Empty);
            btnSearchReset.PerformClick();
            btnAddReset_Click(this, EventArgs.Empty);
            btnAddReset.PerformClick();
            btnDeleteReset_Click(this, EventArgs.Empty);
            btnDeleteReset.PerformClick();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            btnUpdateRoom.Visible = false;
            btnAddRoom.Visible = true;
            txtRoomID.Visible = false;
            lblRoomID.Visible = false;
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            txtRoomID.Visible = true;
            lblRoomID.Visible = true;
            btnUpdateRoom.Visible = true;
            btnAddRoom.Visible = false;
            LoadData();
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
            UpdateEmployeeDataGridView(txtRoomID.Text, dataGridView1, "SELECT * FROM Room WHERE Room_ID LIKE @searchTerm");
        }

        private void rdbDescending_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDescending.Checked)
            {
                rdbAscending.Checked = false;
                string query = "SELECT * FROM Room ORDER BY Room_ID DESC"; // Sort by Room_ID in descending order

                // Step 3: Connect to the database and fill the DataGridView
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Step 4: Bind the data to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }

            }

        }

        private void rdbAscending_CheckedChanged(object sender, EventArgs e)
        {
            
            if (rdbAscending.Checked)
            {
                rdbDescending.Checked = false;

                string query = "SELECT * FROM Room ORDER BY Room_ID ASC"; // Change to DESC for descending order

                // Step 3: Connect to the database and fill the DataGridView
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Step 4: Bind the data to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void btnSearchReset_Click(object sender, EventArgs e)
        {
            txtSearchRoom.Text = string.Empty;
            rdbAscending.Checked = true;
        }

        private void btnAddReset_Click(object sender, EventArgs e)
        {
            txtRoomID.Text = string.Empty;  
            txtEmployeeID.Text = string.Empty;  
            cbxRoomStatus.SelectedIndex = -1;
           
        }

        private void btnDeleteReset_Click(object sender, EventArgs e)
        {
            txtDeleteRoomID.Text = string.Empty;    
        }

        private void MaintainRooms_Load(object sender, EventArgs e)
        {

            LoadData();

        }

        private void cbxRoomStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEmployeeDataGridView((cbxRoomStatus.SelectedIndex).ToString(), dataGridView1, "SELECT * FROM Room WHERE Room_Status LIKE @searchTerm");
        }

        private void UpdateEmployeeDataGridView(string searchTerm, DataGridView dataGridView, string query)
        {

            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@searchTerm", $"%{searchTerm.Trim()}%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            dataGridView.DataSource = dataTable;
        }


        private void txtSearchRoom_TextChanged(object sender, EventArgs e)
        {
            UpdateEmployeeDataGridView(txtSearchRoom.Text, dataGridView1, "SELECT * FROM Room WHERE Room_ID LIKE @searchTerm");

        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedId = Convert.ToInt32(selectedRow.Cells["Room_ID"].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to Delete this record? \nID: " + selectedId, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM Room WHERE Room_ID = " + selectedId;

                    // Use a SqlConnection to connect to the database
                    using (SqlConnection conn = new SqlConnection(connection))
                    {
                        try
                        {
                            conn.Open();

                            // Use a SqlCommand to execute the delete query
                            using (SqlCommand command = new SqlCommand(query, conn))
                            {
                                int rowsAffected = command.ExecuteNonQuery();
                                MessageBox.Show(rowsAffected > 0
                                    ? "Record deleted successfully."
                                    : "No record found with the specified ID.");
                            }
                            LoadData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Action Canceled");
                }
            }
            else
            {
                MessageBox.Show("No record selected. Please select which job you would like to Delete");
            }

        }

        private void txtDeleteRoomID_TextChanged(object sender, EventArgs e)
        {
            UpdateEmployeeDataGridView(txtDeleteRoomID.Text, dataGridView1, "SELECT * FROM Room WHERE Room_ID LIKE @searchTerm");
        }

        private void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {
            UpdateEmployeeDataGridView(txtEmployeeID.Text, dataGridView1, "SELECT * FROM Room WHERE Employee_ID LIKE @searchTerm");
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Room SET Employee_ID = @Value1, Room_Status = @Value2 WHERE Room_ID = @ID";
            string sRoomStatus = cbxRoomStatus.SelectedIndex.ToString();
            string sEmployeeID = txtEmployeeID.Text;

            if (sRoomStatus != "-1" && sEmployeeID != "")
            {

                DialogResult result = MessageBox.Show("Are you sure you want to edit this record? \nID: " + selectedId, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    using (SqlConnection conn = new SqlConnection(connection))
                    {
                        SqlCommand command = new SqlCommand(query, conn);

                        // Add parameters to the SqlCommand
                        command.Parameters.AddWithValue("@Value1", sEmployeeID);
                        command.Parameters.AddWithValue("@Value2", sRoomStatus);
                        command.Parameters.AddWithValue("@ID", selectedId);

                        try
                        {
                            conn.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                Console.WriteLine("Insert successful.");
                                LoadData();
                            }
                            else
                            {
                                Console.WriteLine("Insert failed.");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("An error occurred: " + ex.Message);
                        }
                    }

                }
          
            }
            else
            {
                MessageBox.Show("Fields cannot be Empty");
            }
            LoadData();

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Check if there are any selected rows
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the currently selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                selectedId = Convert.ToInt32(selectedRow.Cells["Room_ID"].Value);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
