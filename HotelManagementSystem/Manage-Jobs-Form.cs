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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace HotelManagementSystem
{
    public partial class ManageJobsForm : Form
    {

        //Connection String
        string connectionString = "Server=DESKTOP-P6754UF;Database=223project;Trusted_Connection=True;";
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

        private void loadData() {

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

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string jobid = txtJobID.Text;
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
            }
        }

            private void btnAcceptNewJob_Click(object sender, EventArgs e)
        {
            string jobtitle = txtAddJobTitle.Text;
            string jobrate = txtAddJobRate.Text;

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

        private void btnAddJob_Click_1(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        private void btnEditJob_Click(object sender, EventArgs e)
        {
            if (dgvJobList.SelectedRows.Count > 0) {
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
            else {
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
                DialogResult result = MessageBox.Show("Are you sure you want to Delete this record? \nID: " + selectedId, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM Job WHERE Job_ID = " + selectedId;

                    // Use a SqlConnection to connect to the database
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();

                            // Use a SqlCommand to execute the delete query
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                int rowsAffected = command.ExecuteNonQuery();
                                MessageBox.Show(rowsAffected > 0
                                    ? "Record deleted successfully."
                                    : "No record found with the specified ID.");
                            }
                            loadData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message);
                        }
                    }
                }
                else {
                    MessageBox.Show("Action Canceled");
                }
            } else
            {
                MessageBox.Show("No record selected. Please select which job you would like to Delete");
            }
        }
    }
}

