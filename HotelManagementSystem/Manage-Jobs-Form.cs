using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace HotelManagementSystem
{
    public partial class ManageJobsForm : Form
    {

        //Connection String
        string connectionString = "Server=DESKTOP-P6754UF;Database=223project;Trusted_Connection=True;";
        string sJobID;
        string sJobRate;
        string sJobTitle;
        int selectedId;
        public ManageJobsForm()
        {
            InitializeComponent();
        }

        private void ManageJobsForm_Load(object sender, EventArgs e)
        {
            loadData();
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            lblSelectedID.Visible = false;
        }

        private void loadData()
        {

            // Define the query to retrieve data
            string query = "SELECT * FROM Job";

            // Create a DataTable to hold the data
            DataTable dataTable = new DataTable();

            // Use a SqlConnection to connect to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Use a SqlDataAdapter to fill the DataTable
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(dataTable);
                    }

                    // Bind the DataGridView to the DataTable
                    dgvJobList.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        private void tcjobs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!(int.TryParse(txtAddJobTitle.Text, out int result)) || txtAddJobTitle.Text == string.Empty)
            {
                // The input is a valid integer
                sJobTitle = txtAddJobTitle.Text;
            }
            else
            {
                // The input is not a valid integer
                MessageBox.Show("Please enter a valid Alphabetical letter.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddJobTitle.Text = sJobTitle;
                txtAddJobTitle.Select(txtAddJobTitle.Text.Length, 0);

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ((int.TryParse(txtAddJobRate.Text, out int result)) || txtAddJobRate.Text == string.Empty)
            {
                // The input is a valid integer
                sJobRate = txtAddJobRate.Text;
            }
            else
            {
                // The input is not a valid integer
                MessageBox.Show("Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddJobRate.Text = sJobRate;
                txtAddJobRate.Select(txtAddJobRate.Text.Length, 0);

            }
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            /*string jobid = txtJobID.Text;
            string jobrate = txtJobRate.Text;
            string jobtitle = txtJobTitle.Text;

            // Start with the base query
            string query = "SELECT * FROM Job WHERE 1=1";

            // Append conditions based on the input values
            if (!string.IsNullOrEmpty(jobid))
            {
                query += " AND Job_ID = " + jobid;
            }
            if (!string.IsNullOrEmpty(jobrate))
            {
                query += " AND Job_Rate = " + jobrate;
            }
            if (!string.IsNullOrEmpty(jobtitle))
            {
                query += " AND Job_Title = '" + jobtitle + "'";
            }

            // Create a DataTable to hold the data
            DataTable dataTable = new DataTable();

            // Use a SqlConnection to connect to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Use a SqlDataAdapter to fill the DataTable
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(dataTable);
                    }

                    // Bind the DataGridView to the DataTable
                    dgvJobList.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }*/
        }

        private void btnAcceptNewJob_Click(object sender, EventArgs e)
        {
            string jobtitle = txtAddJobTitle.Text;
            string jobrate = txtAddJobRate.Text;
            if (jobtitle != "" && jobrate != "")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to Add this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string query = "INSERT INTO Job (Job_Title, Job_Rate) VALUES (@Value2, @Value3)";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(query, connection);

                        // Add parameters to the SqlCommand
                        command.Parameters.AddWithValue("@Value2", jobtitle);
                        command.Parameters.AddWithValue("@Value3", jobrate);

                        try
                        {
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                Console.WriteLine("Insert successful.");
                                loadData();
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
                    lblSelectedID.Visible = false;
                    groupBox1.Visible = false;
                    txtAddJobTitle.Text = "";
                    txtAddJobRate.Text = "";

                }
            }
            else
            {
                MessageBox.Show("Fields cannot be Empty");
            }
        }

        private void btnAddJob_Click_1(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        private void btnEditJob_Click(object sender, EventArgs e)
        {
            if (dgvJobList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvJobList.SelectedRows[0];
                selectedId = Convert.ToInt32(selectedRow.Cells["Job_ID"].Value);
                lblSelectedID.Text = "Selected ID: " + selectedId;
                groupBox2.Visible = true;
                groupBox1.Visible = false;
                lblSelectedID.Visible = true;
            }
            else
            {
                MessageBox.Show("No record selected. Please select which job you would like to edit");
            }
        }

        private void dgvJobList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dgvJobList_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Check if there are any selected rows
            if (dgvJobList.SelectedRows.Count > 0)
            {
                // Get the currently selected row
                DataGridViewRow selectedRow = dgvJobList.SelectedRows[0];

                selectedId = Convert.ToInt32(selectedRow.Cells["Job_ID"].Value);

                lblSelectedID.Text = "Selected Job ID: " + selectedId;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblSelectedID.Visible = false;
            groupBox2.Visible = false;
            txtEditJobTitle.Text = "";
            txtEditJobRate.Text = "";
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            string query = "UPDATE Job SET Job_Title = @Value1, Job_Rate = @Value2 WHERE Job_ID = @ID";
            string jobtitle = txtEditJobTitle.Text;
            string jobrate = txtEditJobRate.Text;

            if (jobtitle != "" && jobrate != "")
            {

                DialogResult result = MessageBox.Show("Are you sure you want to edit this record? \nID: " + selectedId, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(query, connection);

                        // Add parameters to the SqlCommand
                        command.Parameters.AddWithValue("@Value1", jobtitle);
                        command.Parameters.AddWithValue("@Value2", jobrate);
                        command.Parameters.AddWithValue("@ID", selectedId);

                        try
                        {
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                Console.WriteLine("Insert successful.");
                                loadData();
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
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                lblSelectedID.Visible = false;
                txtEditJobTitle.Text = "";
                txtEditJobRate.Text = "";
            }
            else
            {
                MessageBox.Show("Fields cannot be Empty");
            }
            loadData();
        }

        private void btnAddCancel_Click_1(object sender, EventArgs e)
        {
            lblSelectedID.Visible = false;
            groupBox1.Visible = false;
            txtAddJobTitle.Text = "";
            txtAddJobRate.Text = "";
        }

        private void btnDeleteJob_Click(object sender, EventArgs e)
        {
            if (dgvJobList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvJobList.SelectedRows[0];
                selectedId = Convert.ToInt32(selectedRow.Cells["Job_ID"].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to delete this job and all associated employees? \nJob ID: " + selectedId, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Update Room table, delete employees, and delete the job
                    string query = @"
                        BEGIN TRANSACTION;
                        UPDATE Room SET Employee_ID = NULL WHERE Employee_ID IN (SELECT Employee_ID FROM Employee WHERE Job_ID = @JobID);
                        DELETE FROM Employee WHERE Job_ID = @JobID;
                        DELETE FROM Job WHERE Job_ID = @JobID;
                        COMMIT TRANSACTION;
                        ";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@JobID", selectedId);

                                int rowsAffected = command.ExecuteNonQuery();
                                MessageBox.Show(rowsAffected > 0
                                    ? "Job and associated employees deleted successfully."
                                    : "No record found with the specified Job ID.");
                            }
                            loadData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Action canceled.");
                }
            }
            else
            {
                MessageBox.Show("No record selected. Please select a job to delete.");
            }
        }

        private void txtEditJobRate_Validating(object sender, CancelEventArgs e)
        {
            string pattern = @"^-?\d+(\,\d+)?$"; // Allows positive and negative decimals with a comma separator
            if (!Regex.IsMatch(txtEditJobRate.Text, pattern))
            {
                errorProvider1.SetError(txtEditJobRate, "Please enter a valid decimal number.");
                e.Cancel = true; // Prevents the user from leaving the TextBox if validation fails
            }
            else
            {
                errorProvider1.SetError(txtEditJobRate, string.Empty); // Clears the error if the input is valid
            }
        }

        private void txtAddJobRate_Validating(object sender, CancelEventArgs e)
        {
            string pattern = @"^-?\d+(\,\d+)?$"; // Allows positive and negative decimals with a comma separator
            if (!Regex.IsMatch(txtAddJobRate.Text, pattern))
            {
                errorProvider2.SetError(txtAddJobRate, "Please enter a valid decimal number.");
                e.Cancel = true; // Prevents the user from leaving the TextBox if validation fails
            }
            else
            {
                errorProvider2.SetError(txtAddJobRate, string.Empty); // Clears the error if the input is valid
            }
        }

        private void txtJobID_TextChanged(object sender, EventArgs e)
        {
            // Try to parse the text in the TextBox to an integer
            if ((int.TryParse(txtJobID.Text, out int result)) || txtJobID.Text == string.Empty)
            {
                // The input is a valid integer
                UpdateEmployeeDataGridView(txtJobID.Text, dgvJobList, "SELECT * FROM Job WHERE Job_ID LIKE @searchTerm");
                sJobID = txtJobID.Text;
            }
            else
            {
                // The input is not a valid integer
                MessageBox.Show("Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJobID.Text = sJobID;
                txtJobID.Select(txtJobID.Text.Length, 0);

            }
        }

        private void UpdateEmployeeDataGridView(string searchTerm, DataGridView dataGridView, string query)
        {

            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
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

        private void txtJobTitle_TextChanged(object sender, EventArgs e)
        {
            // Try to parse the text in the TextBox to an integer
            if (!(int.TryParse(txtJobTitle.Text, out int result)) || txtJobTitle.Text == string.Empty)
            {
                // The input is a valid integer
                UpdateEmployeeDataGridView(txtJobTitle.Text, dgvJobList, "SELECT * FROM Job WHERE Job_Title LIKE @searchTerm");
                sJobTitle = txtJobTitle.Text;
            }
            else
            {
                // The input is not a valid integer
                MessageBox.Show("Please enter a valid Alphabetical letter.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJobTitle.Text = sJobTitle;
                txtJobTitle.Select(txtJobTitle.Text.Length, 0);

            }
        }

        private void txtJobRate_TextChanged(object sender, EventArgs e)
        {
            // Try to parse the text in the TextBox to an integer
            if ((int.TryParse(txtJobRate.Text, out int result)) || txtJobRate.Text == string.Empty)
            {
                // The input is a valid integer
                UpdateEmployeeDataGridView(txtJobRate.Text, dgvJobList, "SELECT * FROM Job WHERE Job_Rate LIKE @searchTerm");
                sJobRate = txtJobRate.Text;
            }
            else
            {
                // The input is not a valid integer
                MessageBox.Show("Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJobRate.Text = sJobRate;
                txtJobRate.Select(txtJobRate.Text.Length, 0);

            }
        }

        private void txtEditJobTitle_TextChanged(object sender, EventArgs e)
        {
            if (!(int.TryParse(txtEditJobTitle.Text, out int result)) || txtEditJobTitle.Text == string.Empty)
            {
                // The input is a valid integer
                sJobTitle = txtEditJobTitle.Text;
            }
            else
            {
                // The input is not a valid integer
                MessageBox.Show("Please enter a valid Alphabetical letter.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEditJobTitle.Text = sJobTitle;
                txtEditJobTitle.Select(txtEditJobTitle.Text.Length, 0);

            }
        }

        private void txtEditJobRate_TextChanged(object sender, EventArgs e)
        {
            if ((int.TryParse(txtEditJobRate.Text, out int result)) || txtEditJobRate.Text == string.Empty)
            {
                // The input is a valid integer
                sJobRate = txtEditJobRate.Text;
            }
            else
            {
                // The input is not a valid integer
                MessageBox.Show("Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEditJobRate.Text = sJobRate;
                txtEditJobRate.Select(txtEditJobRate.Text.Length, 0);

            }
        }
    }
}

