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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
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
        string sRoomID = "";
        string sEmployeeID = "";

        public void ResetTabPages()
        {
            btnSearchReset_Click(this, EventArgs.Empty);
            btnSearchReset.PerformClick();
            btnAddReset_Click(this, EventArgs.Empty);
            btnAddReset.PerformClick();
            btnDeleteReset_Click(this, EventArgs.Empty);
            btnDeleteReset.PerformClick();
            sRoomID = "";
            sEmployeeID = "";
        }

        public bool IsValueInRoomTable(string columnName, object value)
        {
            string query = "";


            if (columnName == "Room_ID")
            {
                // Write the SQL query to check if the value exists in the specified column
                 query = $"SELECT COUNT(*) FROM Room WHERE {columnName} = @Value";
            }else
            {
                if (columnName == "Employee_ID")
                {
                    // Write the SQL query to check if the value exists in the specified column
                     query = $"SELECT COUNT(*) FROM Employee WHERE {columnName} = @Value";
                }
            }
                    
            

            // Connect to the database and execute the query
            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    //  Add the parameter to the query
                    command.Parameters.AddWithValue("@Value", value);

                    // Open the connection and execute the query
                    conn.Open();
                    int count = (int)command.ExecuteScalar();

                    // Return true if the value exists, otherwise false
                    return count > 0;
                }
            }
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




        private void btnSearch_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            ResetTabPages();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            btnUpdateRoom.Visible = false;
            btnAddRoom.Visible = true;
            txtRoomID.Visible = false;
            lblRoomID.Visible = false;
            LoadData();
            ResetTabPages();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            txtRoomID.Visible = true;
            lblRoomID.Visible = true;
            btnUpdateRoom.Visible = true;
            btnAddRoom.Visible = false;
            btnUpdateRoom.Location = new Point(btnAddRoom.Location.X, btnAddRoom.Location.Y);
            LoadData();
            ResetTabPages();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            ResetTabPages();
        }
        

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // Try to parse the text in the TextBox to an integer
            if ((int.TryParse(txtRoomID.Text, out int result)) || txtRoomID.Text == "")
            {
                // The input is a valid integer
                UpdateEmployeeDataGridView(txtRoomID.Text, dataGridView1, "SELECT * FROM Room WHERE Room_ID LIKE @searchTerm");
                sRoomID = txtRoomID.Text;
            }
            else
            {
                // The input is not a valid integer
                MessageBox.Show("Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRoomID.Text = sRoomID;
                txtRoomID.Select(txtRoomID.Text.Length, 0);

            }
            
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
            cbxSearchStatus.SelectedIndex = -1;
            txtSearchEmployee.Text = string.Empty;
            LoadData();

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
            //UpdateEmployeeDataGridView((cbxRoomStatus.SelectedIndex).ToString(), dataGridView1, "SELECT * FROM Room WHERE Room_Status LIKE @searchTerm");
        }

      

        private void txtSearchRoom_TextChanged(object sender, EventArgs e)
        {
            
            // Try to parse the text in the TextBox to an integer
            if ((int.TryParse(txtSearchRoom.Text, out int result))|| txtSearchRoom.Text == "")
            {
                // The input is a valid integer
                UpdateEmployeeDataGridView(txtSearchRoom.Text, dataGridView1, "SELECT * FROM Room WHERE Room_ID LIKE @searchTerm");
                sRoomID = txtSearchRoom.Text;
            }
            else
            {
                // The input is not a valid integer
                MessageBox.Show("Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearchRoom.Text = sRoomID;
                txtSearchRoom.Select(txtSearchRoom.Text.Length, 0);

            }

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
                MessageBox.Show("No record selected. Please select on data grid which room you would like to Delete");
            }

        }

        private void txtDeleteRoomID_TextChanged(object sender, EventArgs e)
        {
            // Try to parse the text in the TextBox to an integer
            if ((int.TryParse(txtDeleteRoomID.Text, out int result)) || txtDeleteRoomID.Text == "" )
            {
                // The input is a valid integer
                UpdateEmployeeDataGridView(txtDeleteRoomID.Text, dataGridView1, "SELECT * FROM Room WHERE Room_ID LIKE @searchTerm");
                sRoomID = txtDeleteRoomID.Text;
            }
            else
            {
                // The input is not a valid integer
                MessageBox.Show("Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDeleteRoomID.Text = sRoomID;
                txtDeleteRoomID.Select(txtDeleteRoomID.Text.Length, 0);

            }
            
        }

        private void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {
            //UpdateEmployeeDataGridView(txtEmployeeID.Text, dataGridView1, "SELECT * FROM Room WHERE Employee_ID LIKE @searchTerm");
            // Try to parse the text in the TextBox to an integer
            if ((int.TryParse(txtEmployeeID.Text, out int result)) || txtEmployeeID.Text == "" )
            {
                // The input is a valid integer
                sEmployeeID = txtEmployeeID.Text;
            }
            else
            {
                // The input is not a valid integer
                MessageBox.Show("Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmployeeID.Text = sEmployeeID;
                txtEmployeeID.Select(txtEmployeeID.Text.Length, 0);

            }
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Room SET Employee_ID = @Value1, Room_Status = @Value2 WHERE Room_ID = @ID";
            string sRoomStatus = cbxRoomStatus.SelectedIndex.ToString();
            string sEmployeeID = txtEmployeeID.Text;

            if (sRoomStatus != "-1" && sEmployeeID != "")
            {
                if (IsValueInRoomTable("Employee_ID", int.Parse(sEmployeeID)))
                    {               
                    
                        if (dataGridView1.SelectedRows.Count > 0)
                        {
                            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                            int iSelectedID = Convert.ToInt32(selectedRow.Cells["Room_ID"].Value);
                            DialogResult result = MessageBox.Show("Are you sure you want to edit this record? \nID: " + iSelectedID, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {

                                using (SqlConnection conn = new SqlConnection(connection))
                                {
                                    SqlCommand command = new SqlCommand(query, conn);

                                    // Add parameters to the SqlCommand
                                    command.Parameters.AddWithValue("@Value1", sEmployeeID);
                                    command.Parameters.AddWithValue("@Value2", sRoomStatus);
                                    command.Parameters.AddWithValue("@ID", iSelectedID);

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
                        }else { MessageBox.Show("No record selected. Please select on data grid which room you would like to Delete"); }

                    }else{MessageBox.Show("Employee ID does not exist");}                
            }else { MessageBox.Show("Fields cannot be Empty"); }
           

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            // Step 2: Write the SQL query to insert a new room
            string query = "INSERT INTO Room (Employee_ID, Room_Status) VALUES (@Employee_ID, @Room_Status)";
            string sRoomStatus = cbxRoomStatus.SelectedIndex.ToString();
            string sEmployeeID = txtEmployeeID.Text;



            if (sRoomStatus != "-1" && sEmployeeID != "")
            {
                if (IsValueInRoomTable("Employee_ID", int.Parse(sEmployeeID)))
                {

                    DialogResult result = MessageBox.Show("Are you sure you want to Add this record? \nEmployeeID: " + sEmployeeID + "\nRoom Status: " + sRoomStatus, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (result == DialogResult.Yes)
                        {

                            // Step 3: Connect to the database and execute the query
                            using (SqlConnection conn = new SqlConnection(connection))
                            {
                                using (SqlCommand command = new SqlCommand(query, conn))
                                {
                                    // Step 4: Add parameters to the query
                                    command.Parameters.AddWithValue("@Employee_ID", sEmployeeID);
                                    command.Parameters.AddWithValue("@Room_Status", sRoomStatus);

                                    // Step 5: Open the connection and execute the query
                                    conn.Open();
                                    int rowsAffected = command.ExecuteNonQuery();

                                    // Step 6: Check if the insert was successful
                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("New room added successfully.");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Failed to add the new room.");
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Action Canceled");
                        }
                    }
                   
                    
                    

                }else { MessageBox.Show("Employee ID does not exist"); }
                
            }else { MessageBox.Show("Fields cannot be Empty"); }
            LoadData();          
            
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEmployeeDataGridView((cbxSearchStatus.SelectedIndex).ToString(), dataGridView1, "SELECT * FROM Room WHERE Room_Status LIKE @searchTerm");
        }

        private void txtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            // Try to parse the text in the TextBox to an integer
            if ((int.TryParse(txtSearchEmployee.Text, out int result)) || txtSearchEmployee.Text == "")
            {
                // The input is a valid integer
                UpdateEmployeeDataGridView(txtSearchEmployee.Text, dataGridView1, "SELECT * FROM Room WHERE Employee_ID LIKE @searchTerm");
                sEmployeeID = txtSearchEmployee.Text;
            }
            else
            {
                // The input is not a valid integer
                MessageBox.Show("Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearchEmployee.Text =sEmployeeID;
                txtSearchEmployee.Select(txtSearchEmployee.Text.Length, 0);

            }
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
