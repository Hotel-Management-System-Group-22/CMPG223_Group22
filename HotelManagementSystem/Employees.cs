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
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Runtime.ConstrainedExecution;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace HotelManagementSystem
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        string connection = "Data Source=CAITLIN\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True;";


        private void Employees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelManagementSystemDataSet1.Job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this.hotelManagementSystemDataSet1.Job);
            // TODO: This line of code loads data into the 'hotelManagementSystemDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.hotelManagementSystemDataSet.Employee);

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



        private void LoadData()
        {
            string query = "SELECT * FROM Employee";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                employeeDataGridView.DataSource = dataTable;
            }
        }

        //StackOverflow
        public class RandomGenerator
        {
            private static readonly string UppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            private static readonly string LowercaseChars = "abcdefghijklmnopqrstuvwxyz";
            private static readonly string NumberChars = "0123456789";
            private static readonly string SpecialChars = "!@#&*_?";

            // Method to generate a random string with a specific length from a given character set
            private static string GenerateRandomString(int length, string charSet)
            {
                char[] characters = charSet.ToCharArray();
                byte[] data = new byte[length];
                using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
                {
                    rng.GetBytes(data);
                }

                StringBuilder result = new StringBuilder(length);
                foreach (byte b in data)
                {
                    result.Append(characters[b % characters.Length]);
                }

                return result.ToString();
            }

            // Method to generate a username
            public static string GenerateUsername(string name, string lastName)
            {
                string usernameChars = NumberChars;
                return name+lastName+ GenerateRandomString(2, usernameChars);
            }

            // Method to generate a random password for security reasons
            public static string GenerateRandomPassword(int length = 12)
            {
                string passwordChars = UppercaseChars + LowercaseChars + NumberChars + SpecialChars;
                return GenerateRandomString(length, passwordChars);
            }
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
            cmbUpdateJob.SelectedIndex = -1;
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

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            int clerk = 0;
            int admin = 0;
            string name = txtAddFName.Text;
            string surname = txtAddLName.Text;
            if (cmbAddRole.SelectedItem != null)
            {
                string selectedRole = cmbAddRole.SelectedItem.ToString();

                if (selectedRole == "Administrator")
                {
                    admin = 1;
                    clerk = 0;
                }
                else if (selectedRole == "Clerk")
                {
                    admin = 0;
                    clerk = 1;
                }
            }
            int selectedJobID = (int)cmbAddJob.SelectedValue;
            string username = RandomGenerator.GenerateUsername(txtAddFName.Text, txtAddLName.Text);
            string password = RandomGenerator.GenerateRandomPassword();

            string query = "INSERT INTO Employee ( Employee_FName, Employee_LName, Is_Admin_YN, Is_Clerk_YN, Employee_Username, Employee_Password, Job_ID) VALUES (@name, @surname, @admin, @clerk, @username, @password, @jobId)";


            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@surname", surname);
                    command.Parameters.AddWithValue("@admin", admin);
                    command.Parameters.AddWithValue("@clerk", clerk);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@jobId", selectedJobID);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Employee has been added");
                    LoadData();
                }
            }

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteEmp_Click(object sender, EventArgs e)
        {

            string query = "DELETE FROM Employee WHERE Employee_Username = @employeeUsername";
            string username = txtDeleteSerach.Text;

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@employeeUsername", username);

                    DialogResult dialogResult = MessageBox.Show("Are you sure you would like to delete this user:?", "Delete User Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(dialogResult == DialogResult.Yes)
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Employee sucessfully deleted");
                        }
                        else 
                        {
                            MessageBox.Show("No employee found with the provided username.");
                        }
                    }
                    LoadData();
                }
            }
        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            int selectedJobID = (int)cmbAddJob.SelectedValue;
            string query = "UPDATE Employee SET Employee_FName = @newFirstName, Employee_LName = @newLastName, Is_Admin_YN = @isAdmin, Is_Clerk_YN = @isClerk,  Job_ID =  @jobId WHERE Employee_Username = @username";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                int admin = 0;
                int clerk = 0;
                string newFirstName = txtUpdateFName.Text;
                string newLastName = txtUpdateLName.Text;
                string username = txtUpdateSearch.Text;
                if (cmbAddRole.SelectedItem != null)
                {
                    string selectedRole = cmbAddRole.SelectedItem.ToString();

                    if (selectedRole == "Administrator")
                    {
                        admin = 1;
                        clerk = 0;
                    }
                    else if (selectedRole == "Clerk")
                    {
                        admin = 0;
                        clerk = 1;
                    }
                }
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@newFirstName", newFirstName);
                    command.Parameters.AddWithValue("@newLastName", newLastName);
                    command.Parameters.AddWithValue("@isAdmin", admin);
                    command.Parameters.AddWithValue("@isClerk", clerk);
                    command.Parameters.AddWithValue("@jobId", selectedJobID);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Employee successfully updated.");
                    }
                    else
                    {
                        MessageBox.Show("No employee found with the provided username.");
                    }

                    // Optionally refresh DataGridView
                    LoadData();
                }
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (rdoAdmin.Checked)
            {
                UpdateEmployeeDataGridView(txtSearch.Text, employeeDataGridView, "SELECT * FROM Employee WHERE Employee_Username LIKE @searchTerm AND Is_Admin_YN = 1");
            }
            else if (rdoClerk.Checked)
            {
                UpdateEmployeeDataGridView(txtSearch.Text, employeeDataGridView, "SELECT * FROM Employee WHERE Employee_Username LIKE @searchTerm AND Is_Clerk_YN = 1");
            }

            else if (rdoAsc.Checked)
            {
                UpdateEmployeeDataGridView(txtSearch.Text, employeeDataGridView, "SELECT * FROM Employee WHERE Employee_Username LIKE @searchTerm ORDER BY Employee_LName ASC");
            }
            else if (rdoDes.Checked)
            {
                UpdateEmployeeDataGridView(txtSearch.Text, employeeDataGridView, "SELECT * FROM Employee WHERE Employee_Username LIKE @searchTerm ORDER BY Employee_LName DESC");
            }
            else
            {
                UpdateEmployeeDataGridView(txtSearch.Text, employeeDataGridView, "SELECT * FROM Employee WHERE Employee_Username LIKE @searchTerm");
            }

        }

        private void cmbAddJob_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAddFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDeleteSerach_TextChanged(object sender, EventArgs e)
        {
            UpdateEmployeeDataGridView(txtDeleteSerach.Text, employeeDataGridView, "SELECT * FROM Employee WHERE Employee_Username LIKE @searchTerm");
        }

        private void txtUpdateSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateEmployeeDataGridView(txtUpdateSearch.Text, employeeDataGridView, "SELECT * FROM Employee WHERE Employee_Username LIKE @searchTerm");
        }
    }
}

