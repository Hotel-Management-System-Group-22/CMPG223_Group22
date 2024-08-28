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
        bool bAfrikaans = false;

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
                if (bAfrikaans == false)
                {
                    MessageBox.Show("Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Sit Asseblief 'n heelgetal in.", "Ongeldige Invoer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
            cbxSearchStatus.SelectedIndex = 0;
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
                if (bAfrikaans == false)
                {
                    MessageBox.Show("Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Sit Asseblief 'n heelgetal in.", "Ongeldige Invoer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                DialogResult result;
                if (bAfrikaans == false)
                {
                     result = MessageBox.Show("Are you sure you want to Delete this record? \nID: " + selectedId, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                }
                else
                {
                    result = MessageBox.Show("Is jy seker jy wil die record verwyder? \nID: " + selectedId, "Bevestiging", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
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
                    if (bAfrikaans == false)
                    {
                        MessageBox.Show("Action Canceled");
                    }
                    else
                    {
                        MessageBox.Show("Aksie is gekanselleer");
                    }
                }
            }
            else
            {
                if (bAfrikaans == false)
                {
                    MessageBox.Show("No record selected. Please select on data grid which room you would like to Delete");
                }
                else
                {
                    MessageBox.Show("Geen record is gekies nie. Kies asseblief watse kamer jy wil verwyder in die tabel");
                }
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
                if (bAfrikaans == false)
                {
                    MessageBox.Show("Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Sit Asseblief 'n heelgetal in.", "Ongeldige Invoer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                if (bAfrikaans == false)
                {
                    MessageBox.Show("Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Sit Asseblief 'n heelgetal in.", "Ongeldige Invoer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                        DialogResult result;
                        if (bAfrikaans == false)
                        {
                             result = MessageBox.Show("Are you sure you want to edit this record? \nID: " + iSelectedID, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        }
                        else
                        {
                            result = MessageBox.Show("Is jy seker jy wil die record byvoeg \nID: " + iSelectedID, "Bevestiging", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        }
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
                                        if (bAfrikaans == false)
                                        {
                                            MessageBox.Show("Room Updated");
                                        }
                                        else
                                        {
                                            MessageBox.Show("Kamer Opgedateer");
                                        }
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
                        }else 
                    { 
                        if (bAfrikaans == false)
                        {
                            MessageBox.Show("No record selected. Please select on data grid which room you would like to Update");
                        }
                        else
                        {
                            MessageBox.Show("Geen record is gekies nie. Kies asseblief watse kamer jy wil opdateer in die tabel");
                        }

                    }

                    }else{
                    if (bAfrikaans == false)
                    {
                        MessageBox.Show("Employee ID does not exist.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Werknemer ID bestaan nie.", "Ongeldige Invoer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }                
            }else {
                if (bAfrikaans == false)
                {
                    MessageBox.Show("Fields cannot be Empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else 
                {
                    MessageBox.Show("Velde mag nie leeg wees nie.", "Ongeldige Invoer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
           

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
                    DialogResult result;
                    if (bAfrikaans == false)
                    {
                         result = MessageBox.Show("Are you sure you want to Add this record? \nEmployeeID: " + sEmployeeID + "\nRoom Status: " + sRoomStatus, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                    else
                    {
                         result = MessageBox.Show("Is jy seker jy wil die record byvoeg \nEmployeeID: " + sEmployeeID + "\nRoom Status: " + sRoomStatus, "Bevestiging", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                   
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
                                        
                                        if (bAfrikaans == false)
                                        {
                                            MessageBox.Show("New room added successfully.");
                                        }
                                        else
                                        {
                                            MessageBox.Show("Nuwe kamer is suksesvol bygevoeg.");
                                        }
                                    }
                                    else
                                    {
                                        if (bAfrikaans == false)
                                        {
                                            MessageBox.Show("Failed to add the new room.");
                                        }
                                        else
                                        {
                                            MessageBox.Show("Kon nie die nuwe kamer byvoeg nie.");
                                        }
                                        
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (bAfrikaans == false)
                            {
                                MessageBox.Show("Action Canceled");
                            }
                            else
                            {
                                MessageBox.Show("Aksie is gekanselleer");
                            }
                            
                        }
                    }
                   
                    
                    

                }else {
                    if (bAfrikaans == false)
                    {
                        MessageBox.Show("Employee ID does not exist.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Werknemer ID bestaan nie.", "Ongeldige Invoer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                   }
                
            }else { 
                
                if (bAfrikaans == false)
                {
                    MessageBox.Show("Fields cannot be Empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Velde mag nie leeg wees nie.", "Ongeldige Invoer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
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
                if (bAfrikaans == false)
                {
                    MessageBox.Show("Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Sit Asseblief 'n heelgetal in.", "Ongeldige Invoer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                    
                txtSearchEmployee.Text =sEmployeeID;
                txtSearchEmployee.Select(txtSearchEmployee.Text.Length, 0);

            }
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            toolTip1.AutoPopDelay = 4000; // 4 seconds
            toolTip1.InitialDelay = 700; // 0.7 seconds
            toolTip1.ReshowDelay = 500;   // 0.5 seconds

            if (bAfrikaans == false)
            {
                bAfrikaans = true;
                btnLanguage.Text = "English";
                //Menu
                btnMenuSearch.Text = "Soek";
                btnMenuAdd.Text = "Voeg by";
                btnMenuUpdate.Text = "Opdateer";
                btnMenuDelete.Text = "Verwyder";
                //Search
                lblSearchRoomID.Text = "Soek Kamer ID";
                lblSearchEmployeeID.Text = "Soek Werknemer ID";
                lblSearchRoomStatus.Text = "Kamer status";
                lblSearchSortRoomID.Text = "Sorteer by kamer ID";
                rdbAscending.Text = "Stygend";
                rdbDescending.Text = "Dalend";
                btnSearchReset.Text = "Herstel";
                cbxSearchStatus.Items.Clear();
                cbxSearchStatus.Items.Add("Onbeset");
                cbxSearchStatus.Items.Add("Beset");
                //Update and delete page
                lblRoomID.Text = "Kamer ID";
                lblEmployeeID.Text = "Werknemer ID";
                lblRoomStatus.Text = "Kamer status";
                cbxRoomStatus.Items.Clear();
                cbxRoomStatus.Items.Add("Onbeset");
                cbxRoomStatus.Items.Add("Beset");
                btnAddReset.Text = "Herstel";
                btnAddRoom.Text = "Voeg Kamer by";
                btnUpdateRoom.Text = "Opdateer Kamer";
                //Delete
                btnDeleteReset.Text = "Herstel";
                btnDeleteRoom.Text = "Verwyder Kamer";
                lblDeleteRoomID.Text = "Soek volgens kamer ID";
                // Buttons
                toolTip1.SetToolTip(btnAddReset, "");
                toolTip1.SetToolTip(btnAddRoom, "");
                toolTip1.SetToolTip(btnDeleteReset, "");
                toolTip1.SetToolTip(btnDeleteRoom, "");
                toolTip1.SetToolTip(btnLanguage, "");
                toolTip1.SetToolTip(btnMenuAdd, "");
                toolTip1.SetToolTip(btnMenuDelete, "");
                toolTip1.SetToolTip(btnMenuSearch, "");
                toolTip1.SetToolTip(btnMenuUpdate, "");
                toolTip1.SetToolTip(btnSearchReset, "");
                toolTip1.SetToolTip(btnUpdateRoom, "");

                // TextBoxes
                toolTip1.SetToolTip(txtDeleteRoomID, "");
                toolTip1.SetToolTip(txtEmployeeID, "");
                toolTip1.SetToolTip(txtRoomID, "");
                toolTip1.SetToolTip(txtSearchEmployee, "");
                toolTip1.SetToolTip(txtSearchRoom, "");

            }
            else
            {
                bAfrikaans = false;
                btnLanguage.Text = "Afrikaans";
                //Menu
                btnMenuSearch.Text = "Search";
                btnMenuAdd.Text = "Add";
                btnMenuUpdate.Text = "Update";
                btnMenuDelete.Text = "Delete";
                //Search
                lblSearchRoomID.Text = "Search Room ID";
                lblSearchEmployeeID.Text = "Search Employee ID";
                lblSearchRoomStatus.Text = "Room status";
                lblSearchSortRoomID.Text = "Sort by Room ID";
                rdbAscending.Text = "Ascending";
                rdbDescending.Text = "Descending";
                btnSearchReset.Text = "Reset";
                cbxSearchStatus.Items.Clear();
                cbxSearchStatus.Items.Add("Unoccupied");
                cbxSearchStatus.Items.Add("Occupied");
                //Update and delete page
                lblRoomID.Text = "Room ID";
                lblEmployeeID.Text = "Empluyee ID";
                lblRoomStatus.Text = "Room status";
                cbxRoomStatus.Items.Clear();
                cbxRoomStatus.Items.Add("Unoccupied");
                cbxRoomStatus.Items.Add("Occupied");
                btnAddReset.Text = "Reset";
                btnAddRoom.Text = "Add Room";
                btnUpdateRoom.Text = "Update Room";
                //Delete
                btnDeleteReset.Text = "Reset";
                btnDeleteRoom.Text = "Delete Room";
                lblDeleteRoomID.Text = "Search by Room ID";
                // Buttons
                toolTip1.SetToolTip(btnAddReset, "Reset the form to its default state before adding a new entry.");
                toolTip1.SetToolTip(btnAddRoom, "Add a new room to the system.");
                toolTip1.SetToolTip(btnDeleteReset, "Clear the current selection and reset the delete form.");
                toolTip1.SetToolTip(btnDeleteRoom, "Delete the selected room from the system.");
                toolTip1.SetToolTip(btnLanguage, "Switch between available languages.");
                toolTip1.SetToolTip(btnMenuAdd, "Open the menu to add new items.");
                toolTip1.SetToolTip(btnMenuDelete, "Open the menu to delete existing items.");
                toolTip1.SetToolTip(btnMenuSearch, "Open the menu to search for items.");
                toolTip1.SetToolTip(btnMenuUpdate, "Open the menu to update existing items.");
                toolTip1.SetToolTip(btnSearchReset, "Reset the search filters and criteria.");
                toolTip1.SetToolTip(btnUpdateRoom, "Update the details of the selected room.");
                // TextBoxes
                toolTip1.SetToolTip(txtDeleteRoomID, "Enter the Room ID to delete.");
                toolTip1.SetToolTip(txtEmployeeID, "Enter the Employee ID.");
                toolTip1.SetToolTip(txtRoomID, "Enter the Room ID.");
                toolTip1.SetToolTip(txtSearchEmployee, "Enter the Employee ID or name to search.");
                toolTip1.SetToolTip(txtSearchRoom, "Enter the Room ID or name to search.");


            }
        }
    }
}
