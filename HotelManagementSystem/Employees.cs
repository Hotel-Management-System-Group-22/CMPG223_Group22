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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using System.Diagnostics.Eventing.Reader;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace HotelManagementSystem
{
    public partial class Employees : Form
    {
        private bool bAfrikaans = false;
        public Employees()
        {
            InitializeComponent();
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
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
                return name + lastName + GenerateRandomString(2, usernameChars);
            }

            // Method to generate a random password for security reasons
            public static string GenerateRandomPassword(int length = 12)
            {
                string passwordChars = UppercaseChars + LowercaseChars + NumberChars + SpecialChars;
                return GenerateRandomString(length, passwordChars);
            }
        }
        /* public bool checkNames(string name)
         {
             if (string.IsNullOrEmpty(name))
             {
                 errorProvider1.SetError(txtAddFName, "Please enter " + txtAddFName.Text);
             }

             // Check if the first character is uppercase
             if (!char.IsUpper(name[0]))
             {
                 errorProvider1.SetError(txtAddFName, "Please start with Capital Letter");
             }

             // Check if all remaining characters are lowercase
             for (int i = 1; i < name.Length; i++)
             {
                 if (!char.IsLower(name[i]))
                 {
                     errorProvider1.SetError(txtAddFName, "Must only contain letters");
                 }
             }

             return true;
         }
         */

        private void ValidateTextBox(System.Windows.Forms.TextBox textBox)
        {
            if (textBox != null)
            {
                string input = textBox.Text;
                if (!IsTextValid(input))
                {
                    if (bAfrikaans)
                    {
                        errorProvider1.SetError(textBox, "Input must contain only letters and first letter must be capitilized.");
                    }
                    else
                    {
                        errorProvider1.SetError(textBox, "Invoer moet slegs letters bevat en die eerste letter moet gekapitaliseer word.");
                    }
                }
                else
                {
                    errorProvider1.SetError(textBox, string.Empty);
                }
            }
            else
            {
                if (bAfrikaans)
                {
                    errorProvider1.SetError(textBox, "Please fill the textbox");
                }
                else
                {
                    errorProvider1.SetError(textBox, "Vul asseblief die teksboks in");
                }
            }
        }

        private bool IsTextValid(string text)
        {
            // Regular expression to match only letters (Ensures that first letter is capitalized and rest lowercase)
            Regex regex = new Regex("^[A-Z][a-zA-Z]*$");
            return regex.IsMatch(text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAddFName.Clear();
            txtAddLName.Clear();
            cmbAddJob.SelectedIndex = -1;
            cmbAddRole.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cmbAddRole.SelectedIndex = -1;
            cmbAddJob.SelectedIndex = -1;
            tabControl1.SelectedTab = tabPage3;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cmbUpdateRole.SelectedIndex = -1;
            cmbUpdateJob.SelectedIndex = -1;
            tabControl1.SelectedTab = tabPage1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
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
            //txtDeleteSerach.Clear();
        }

        private void btnSearchReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtSearchFName.Clear();
            txtSearchLName.Clear();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelManagementSystemDataSet);

        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            ValidateTextBox(txtAddFName);
            ValidateTextBox(txtAddLName);
            if (cmbAddJob.SelectedIndex == -1)
            {
                if (bAfrikaans)
                {
                    errorProvider1.SetError(cmbAddJob, "Please select job");
                }
                else
                {
                    errorProvider1.SetError(cmbAddJob, "Kies asseblief werk");
                }
            }
            else if (cmbAddRole.SelectedIndex == -1)
            {
                if (bAfrikaans)
                {
                    errorProvider1.SetError(cmbAddRole, "Please select role");
                }
                else
                {
                    errorProvider1.SetError(cmbAddRole, "Kies asseblief rol");
                }
            }
            if (string.IsNullOrEmpty(errorProvider1.GetError(txtAddFName)) && string.IsNullOrEmpty(errorProvider1.GetError(txtAddLName)) && cmbAddRole.SelectedItem != null && cmbAddJob.SelectedItem != null)
            {
                int clerk = 0;
                int admin = 0;
                string name = txtAddFName.Text;
                string surname = txtAddLName.Text;

                if (cmbAddRole.SelectedItem != null)
                {
                    string selectedRole = cmbAddRole.SelectedItem.ToString();
                    if (bAfrikaans)
                    {
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
                    else
                    {
                        errorProvider1.SetError(cmbAddRole, "Kies asseblief rol");
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
                        if (bAfrikaans)
                        {
                            MessageBox.Show("Employee " + name + " " + surname + " has been added");
                            MessageBox.Show("Employee username: " + username + "\n" + "Employee default password: " + password);
                            //MessageBox.Show("Employee default password: " + password);
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Werknemer " + name + " " + surname + " is bygevoeg");
                            MessageBox.Show("Werknemer gebruikersnaam: " + username + "\n" + "Werknemer verstek wagwoord: " + password);
                            //MessageBox.Show("Werknemer verstek wagwoord: " + wagwoord);
                            LoadData();
                        }
                       
                    }
                }
            }
            else
            {
                if (bAfrikaans)
                {
                    MessageBox.Show("Please complete all fields and ensure all errors are corrected");
                }
                else
                {
                    MessageBox.Show("Vul asseblief alle velde in en maak seker dat alle foute reggestel word");
                }
            }
        }



        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteEmp_Click(object sender, EventArgs e)
        {
            //PopulateDeleteFields(selectedEmployeeID);

            if (selectedEmployeeID == -1)
            {
                if (bAfrikaans)
                {
                    MessageBox.Show("No Employee selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Geen werknemer gekies nie.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            string Deletequery = "DELETE FROM Employee WHERE Employee_ID = @EmployeeId";
            //D:SN
            string setNull = "UPDATE Room SET Employee_ID = NULL WHERE Employee_ID = @EmployeeID";
            //string username = txtDeleteSerach.Text;

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                //Referencial integrity if employee is deleted, must be set to null in room
                using (SqlCommand referencialintegrity = new SqlCommand(setNull, conn))
                {
                    referencialintegrity.Parameters.AddWithValue("@EmployeeId", selectedEmployeeID);
                    referencialintegrity.ExecuteNonQuery();
                }
                using (SqlCommand command = new SqlCommand(Deletequery, conn))
                {
                    command.Parameters.AddWithValue("@EmployeeId", selectedEmployeeID);

                    if (!cbConfirm.Checked)
                    {
                        if (bAfrikaans)
                        {
                            MessageBox.Show("Please check the checkbox if the information in 'Verify Employee Details' matches the employee you intend to delete");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Merk asseblief die merkblokkie as die inligting in 'Verifieer werknemerbesonderhede' ooreenstem met die werknemer wat jy van plan is om uit te vee");
                            return;
                        }
                    }
                    DialogResult dialogResult;
                    if (bAfrikaans)
                    {
                        MessageBox.Show("Are you sure you would like to delete this user:?", "Delete User Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Is jy seker jy wil hierdie gebruiker uitvee:?", "Delete User Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); 
                        return;
                    }
                    if (dialogResult == DialogResult.Yes)
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            command.ExecuteNonQuery();
                            if (bAfrikaans)
                            {
                                MessageBox.Show("Employee sucessfully deleted");
                                txtVerifyClerk.Text = " ";
                                txtVerifyAdmin.Text = " ";
                                txtVerifyFName.Text = " ";
                                txtVerifyLName.Text = " ";
                                txtVerifyJob.Text = " ";
                            }
                            else
                            {
                                MessageBox.Show("Werknemer suksesvol verwyder");
                                txtVerifyClerk.Text = " ";
                                txtVerifyAdmin.Text = " ";
                                txtVerifyFName.Text = " ";
                                txtVerifyLName.Text = " ";
                                txtVerifyJob.Text = " ";
                            }
                        }
                        else
                        {
                            if (bAfrikaans)
                            {
                                MessageBox.Show("No employee found with the provided username.");
                            }
                            else
                            {
                                MessageBox.Show("Geen werknemer gevind met die verskafde gebruikersnaam nie.");
                            }
                        }
                    }
                    LoadData();
                }
            }
        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            if (selectedEmployeeID == -1)
            {
                if (bAfrikaans)
                {
                    MessageBox.Show("No employee selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Geen werknemer gekies nie.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            ValidateTextBox(txtUpdateFName);
            ValidateTextBox(txtUpdateLName);
            if (cmbUpdateJob.SelectedIndex == -1)
            {
                if (bAfrikaans)
                {
                    errorProvider1.SetError(cmbUpdateJob, "Please select job");
                }
                else
                {
                    errorProvider1.SetError(cmbUpdateJob, "Kies asseblief werk");
                }
            }
            else if (cmbUpdateRole.SelectedIndex == -1)
            {
                if (bAfrikaans)
                {
                    errorProvider1.SetError(cmbUpdateRole, "Please select role");
                }
                else
                {
                    errorProvider1.SetError(cmbUpdateRole, "Kies asseblief rol");
                }
            }
            // Check if username is provided
            if (string.IsNullOrWhiteSpace(txtUpdateSearch.Text))
            {
                if (bAfrikaans)
                {
                    MessageBox.Show("Please enter the username to search for the employee.");
                    return;
                }
                else
                {
                    MessageBox.Show("Tik asseblief die gebruikersnaam in om na die werknemer te soek.");
                    return;
                }
            }

            // Show initial confirmation message
            DialogResult initialConfirm;
            if (bAfrikaans == false)
            {
                initialConfirm = MessageBox.Show("Are you sure you want to update this employee's details?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                initialConfirm = MessageBox.Show("Is jy seker jy wil hierdie werknemer se besonderhede opdateer?", "Bevestig opdatering", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

            if (initialConfirm == DialogResult.No)
            {
                if (bAfrikaans)
                {
                    MessageBox.Show("Update cancelled.");
                    return; // Exit the method if the user does not confirm
                }
                else
                {
                    MessageBox.Show("Opdatering gekanselleer.");
                    return;
                }
            }
            // Clear previous errors
            errorProvider1.Clear();

            // Validate inputs
            bool hasErrors = !string.IsNullOrEmpty(errorProvider1.GetError(txtUpdateFName)) || !string.IsNullOrEmpty(errorProvider1.GetError(txtUpdateLName));

            if (string.IsNullOrEmpty(txtUpdateFName.Text.Trim()) && string.IsNullOrEmpty(txtUpdateLName.Text.Trim()) && cmbUpdateRole.SelectedItem == null && cmbUpdateJob.SelectedItem == null)
            {
                if (bAfrikaans)
                {
                    MessageBox.Show("No updates applied. Please make at least one change.");
                    return; // Exit the method if no changes are made
                }
                else
                {
                    MessageBox.Show("Geen opdaterings toegepas nie. Maak asseblief ten minste een verandering.");
                    return;
                }
            }

            // Proceed with updating the employee
            int selectedJobID = (int)cmbAddJob.SelectedValue;
            string query = "UPDATE Employee SET " +
                           "Employee_FName = COALESCE(NULLIF(@newFirstName, ''), Employee_FName), " +
                           "Employee_LName = COALESCE(NULLIF(@newLastName, ''), Employee_LName), " +
                           "Is_Admin_YN = @isAdmin, " +
                           "Is_Clerk_YN = @isClerk, " +
                           "Job_ID = @jobId " +
                           "WHERE Employee_ID = @EmployeeId";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                int admin = 0;
                int clerk = 0;
                string newFirstName = txtUpdateFName.Text.Trim();
                string newLastName = txtUpdateLName.Text.Trim();
                string username = txtUpdateSearch.Text.Trim();
                bool usernameChanged = false;

                if (cmbUpdateRole.SelectedItem != null)
                {
                    string selectedRole = cmbUpdateRole.SelectedItem.ToString();
                    if (bAfrikaans)
                    {
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
                    else
                    {
                        if (selectedRole == "Administrateur")
                        {
                            admin = 1;
                            clerk = 0;
                        }
                        else if (selectedRole == "Klerk")
                        {
                            admin = 0;
                            clerk = 1;
                        }
                    }

                }
                if (!string.IsNullOrEmpty(newFirstName) && !string.IsNullOrEmpty(newLastName))
                {
                    string newUsername = RandomGenerator.GenerateUsername(newFirstName, newLastName);
                    usernameChanged = true;
                    string queryUsername = "UPDATE Employee SET Employee_Username = @newUsername WHERE Employee_Username = @oldUsername";
                    using (SqlCommand cmdUsername = new SqlCommand(queryUsername, conn))
                    {
                        cmdUsername.Parameters.AddWithValue("@newUsername", newUsername);
                        cmdUsername.Parameters.AddWithValue("@oldUsername", username);
                        cmdUsername.ExecuteNonQuery();
                        usernameChanged = true;
                    }
                    username = newUsername; // Update the username variable
                }
                else if (!string.IsNullOrEmpty(newFirstName) && string.IsNullOrEmpty(newLastName))
                {
                    if (bAfrikaans)
                    {
                        errorProvider1.SetError(txtUpdateLName, "Please enter corresponding last name");
                        hasErrors = true;
                    }
                    else
                    {
                        errorProvider1.SetError(txtUpdateLName, "Voer asseblief ooreenstemmende van in");
                        hasErrors = true;
                    }
                }
                else if (string.IsNullOrEmpty(newFirstName) && !string.IsNullOrEmpty(newLastName))
                {
                    if (bAfrikaans)
                    {
                        errorProvider1.SetError(txtUpdateFName, "Please enter corresponding first name");
                        hasErrors = true;
                    }
                    else
                    {
                        errorProvider1.SetError(txtUpdateFName, "Voer asseblief ooreenstemmende voornaam in");
                        hasErrors = true;
                    }
                }
                // Execute update command only if there are no errors
                if (!hasErrors)
                {
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@EmployeeId", selectedEmployeeID);
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@newFirstName", newFirstName);
                        command.Parameters.AddWithValue("@newLastName", newLastName);
                        command.Parameters.AddWithValue("@isAdmin", admin);
                        command.Parameters.AddWithValue("@isClerk", clerk);
                        command.Parameters.AddWithValue("@jobId", selectedJobID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Show success message only if no errors
                            if (!hasErrors)
                            {
                                if (usernameChanged)
                                {
                                    if (bAfrikaans)
                                    {
                                        MessageBox.Show("Employees new username: " + username);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Werknemers nuwe gebruikersnaam: " + username);
                                    }

                                    if (bAfrikaans)
                                    {
                                        MessageBox.Show("Employee has been successfully updated.");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Werknemer is suksesvol opgedateer.");
                                    }

                                    txtUpdateFName.Text = " ";
                                    txtUpdateLName.Text = " ";
                                    txtUpdateSearch.Text = " ";
                                    cmbUpdateJob.SelectedIndex = -1;
                                    cmbUpdateRole.SelectedIndex = -1;
                                }
                                else
                                {
                                    if (bAfrikaans)
                                    {
                                        MessageBox.Show("No employee found with the provided username.");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Geen werknemer gevind met die verskafde gebruikersnaam nie.");
                                    }
                                }

                                // Optionally refresh DataGridView
                                LoadData();

                            }
                            else
                            {
                                if (bAfrikaans)
                                {
                                    MessageBox.Show("Please fix errors before updating");
                                }
                                else
                                {
                                    MessageBox.Show("Repareer asseblief foute voor opdatering");
                                }
                            }
                        }
                    }
                }
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Get the search term and trim any extra whitespace
            string searchTerm = txtUsername.Text.Trim();

            // Construct the SQL query based on the selected filter
            string query = "SELECT * FROM Employee WHERE Employee_Username LIKE @searchTerm";

            if (rdoAdmin.Checked)
            {
                query += " AND Is_Admin_YN = 1";
            }
            else if (rdoClerk.Checked)
            {
                query += " AND Is_Clerk_YN = 1";
            }
            else if (rdoAsc.Checked)
            {
                query += " ORDER BY Employee_LName ASC";
            }
            else if (rdoDes.Checked)
            {
                query += " ORDER BY Employee_LName DESC";
            }

            // Update the DataGridView with the constructed query
            UpdateEmployeeDataGridView(searchTerm, employeeDataGridView, query);
        }

        private void cmbAddJob_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAddFName_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(txtAddFName);

        }

        private void txtDeleteSerach_TextChanged(object sender, EventArgs e)
        {
            //UpdateEmployeeDataGridView(txtDeleteSerach.Text, employeeDataGridView, "SELECT * FROM Employee WHERE Employee_Username LIKE @searchTerm");
        }

        private void txtUpdateSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtAddLName_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(txtAddLName);
        }

        private void txtUpdateFName_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(txtUpdateFName);
        }

        private void txtUpdateLName_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(txtUpdateLName);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string filterQuery = "";
            string searchQuery = "";
            string sortOrder = "";

            // Filter based on role
            if (rdoAdmin.Checked)
            {
                filterQuery = "WHERE Role = 'Admin'";
            }
            else if (rdoClerk.Checked)
            {
                filterQuery = "WHERE Role = 'Clerk'";
            }
            else if (rdoStaff.Checked)
            {
                filterQuery = "WHERE Role = 'Employee'";
            }

            // Add search criteria
            if (!string.IsNullOrEmpty(txtUsername.Text))
            {
                searchQuery += " AND Username LIKE @username";
            }
            if (!string.IsNullOrEmpty(txtSearchFName.Text))
            {
                searchQuery += " AND FirstName LIKE @firstName";
            }
            if (!string.IsNullOrEmpty(txtSearchLName.Text))
            {
                searchQuery += " AND LastName LIKE @lastName";
            }

            // Sorting order
            if (rdoAsc.Checked)
            {
                sortOrder = "ORDER BY Username ASC";
            }
            else if (rdoDes.Checked)
            {
                sortOrder = "ORDER BY Username DESC";
            }

            // Combine all queries
            string query = $"SELECT * FROM Employee {filterQuery} {searchQuery} {sortOrder}";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    // Add parameters to avoid SQL injection
                    if (!string.IsNullOrEmpty(txtUsername.Text))
                    {
                        command.Parameters.AddWithValue("@username", "%" + txtUsername.Text + "%");
                    }
                    if (!string.IsNullOrEmpty(txtSearchFName.Text))
                    {
                        command.Parameters.AddWithValue("@firstName", "%" + txtSearchFName.Text + "%");
                    }
                    if (!string.IsNullOrEmpty(txtSearchLName.Text))
                    {
                        command.Parameters.AddWithValue("@lastName", "%" + txtSearchLName.Text + "%");
                    }

                    // Execute the query and fill the DataGridView
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        employeeDataGridView.DataSource = dt;
                    }
                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private int selectedEmployeeID = -1;
        private void populateDeleteFields(int employeeID)
        {
            string Selectquery = "SELECT Employee_FName, Employee_LName, Is_Admin_YN, Is_Clerk_YN, Job_Id FROM Employee WHERE Employee_ID = @EmployeeId";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand(Selectquery, conn))
                {
                    command.Parameters.AddWithValue("@EmployeeId", employeeID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Populate the text boxes with the retrieved data
                            txtVerifyFName.Text = reader["Employee_FName"].ToString();
                            txtVerifyLName.Text = reader["Employee_LName"].ToString();
                            txtVerifyAdmin.Text = Convert.ToBoolean(reader["Is_Admin_YN"]) ? "Yes" : "No";
                            txtVerifyClerk.Text = Convert.ToBoolean(reader["Is_Clerk_YN"]) ? "Yes" : "No";
                            txtVerifyJob.Text = reader["Job_Id"].ToString();
                        }
                        else
                        {
                            if (bAfrikaans)
                            {
                                MessageBox.Show("No employee found with the provided ID.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //ClearVerifyFields(); // Optionally clear fields if no employee is found
                            }
                            else
                            {
                                MessageBox.Show("Geen werknemer gevind met die verskafde ID nie.", "Soekresultaat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
        }

        private void populateUpdateFields(int employeeID)
        {
            string Selectquery = "SELECT Employee_FName, Employee_LName, Is_Admin_YN, Is_Clerk_YN, Job_Id, Employee_Username FROM Employee WHERE Employee_ID = @EmployeeId";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand(Selectquery, conn))
                {
                    command.Parameters.AddWithValue("@EmployeeId", employeeID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Populate the text boxes with the retrieved data
                            txtUpdateSearch.Text = reader["Employee_Username"].ToString();
                            txtUpdateFName.Text = reader["Employee_FName"].ToString();
                            txtUpdateLName.Text = reader["Employee_LName"].ToString();
                            bool isAdmin = Convert.ToBoolean(reader["Is_Admin_YN"]);
                            bool isClerk = Convert.ToBoolean(reader["Is_Clerk_YN"]);

                            // Update the ComboBox based on the values retrieved
                            cmbUpdateRole.SelectedIndex = isAdmin ? 0 : 1; // Example: 0 for Admin, 1 for Clerk (adjust as needed)

                            // Populate the job ComboBox
                            int jobId = Convert.ToInt32(reader["Job_Id"]);
                            cmbUpdateJob.SelectedValue = jobId;
                        }
                        else
                        {
                            if (bAfrikaans)
                            {
                                MessageBox.Show("No employee found with the provided ID.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Geen werknemer gevind met die verskafde ID nie.", "Soekresultaat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
        }

        private void employeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Ensure valid row and column index
            {
                DataGridViewRow row = employeeDataGridView.Rows[e.RowIndex];

                // Ensure the correct column name is used
                if (row.Cells["Employee_ID"] != null && row.Cells["Employee_ID"].Value != DBNull.Value)
                {
                    selectedEmployeeID = Convert.ToInt32(row.Cells["Employee_ID"].Value);

                    // Check which tab or mode is active and populate fields accordingly
                    if (tabControl1.SelectedTab == tabPage1)
                    {
                        populateUpdateFields(selectedEmployeeID);
                    }
                    else if (tabControl1.SelectedTab == tabPage2)
                    {
                        populateDeleteFields(selectedEmployeeID);
                    }
                }
                else
                {
                    if (bAfrikaans)
                    {
                        MessageBox.Show("Employee_ID not found or missing in the selected row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        selectedEmployeeID = -1; // Default to invalid ID if cell value is not present
                    }
                    else
                    {
                        MessageBox.Show("Werknemer_ID nie gevind of ontbreek in die geselekteerde ry nie.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        selectedEmployeeID = -1;
                    }
                }
            }
        }


        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            /*
            //string username = txtDeleteSerach.Text;
            
            string Selectquery = "SELECT Employee_FName, Employee_LName, Is_Admin_YN, Is_Clerk_YN, Job_Id FROM Employee WHERE Employee_ID = @EmployeeId";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand(Selectquery, conn))
                {
                    command.Parameters.AddWithValue("@EmployeeId", selectedEmployeeID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Populate the text boxes with the retrieved data
                            txtVerifyFName.Text = reader["Employee_FName"].ToString();
                            txtVerifyLName.Text = reader["Employee_LName"].ToString();
                            txtVerifyAdmin.Text = Convert.ToBoolean(reader["Is_Admin_YN"]) ? "Yes" : "No";
                            txtVerifyClerk.Text = Convert.ToBoolean(reader["Is_Clerk_YN"]) ? "Yes" : "No";
                            txtVerifyJob.Text = reader["Job_Id"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No employee found with the provided username.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                            //ClearVerifyFields(); // Optionally clear fields if no employee is found
                        }
                    }
                }
            }
            */
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            /*string username = txtUpdateSearch.Text;
            string Selectquery = "SELECT Employee_FName, Employee_LName, Is_Admin_YN, Is_Clerk_YN, Job_Id FROM Employee WHERE Employee_Username = @username";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand(Selectquery, conn))
                {
                    command.Parameters.AddWithValue("@username", username);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Populate the text boxes with the retrieved data
                            txtUpdateFName.Text = reader["Employee_FName"].ToString();
                            txtUpdateLName.Text = reader["Employee_LName"].ToString();
                            bool isAdmin = Convert.ToBoolean(reader["Is_Admin_YN"]);
                            bool isClerk = Convert.ToBoolean(reader["Is_Clerk_YN"]);

                            // Update the ComboBox based on the values retrieved
                            cmbUpdateRole.SelectedIndex = isAdmin ? 0 : 1; // Example: 0 for Admin, 1 for Clerk (adjust as needed)

                            // Populate the job ComboBox
                            int jobId = Convert.ToInt32(reader["Job_Id"]);
                            cmbUpdateJob.SelectedValue = jobId;


                        }
                        else
                        {
                            MessageBox.Show("No employee found with the provided username.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                            //ClearVerifyFields(); // Optionally clear fields if no employee is found
                        }
                    }
                }
            }
            */
        }

        private void button3_Click(object sender, EventArgs e)
        {
           rdoAdmin.Checked = false;
           rdoStaff.Checked = false;
           rdoClerk.Checked = false;
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            if (bAfrikaans == false)
            {
                //Main buttons
                btnSearch.Text = "SEARCH";
                btnAdd.Text = "ADD";
                btnUpdate.Text = "UPDATE";
                btnDelete.Text = "DELETE";
                btnLanguage.Text = "LANGUAGE";

                //Update labels
                lblUpdateUsername.Text = "Employee Username:";
                lblUpdateFirstName.Text = "First Name:";
                lblUpdateLastName.Text = "Last Name:";
                lblUpdateJobTitle.Text = "Job Title:";
                lblUpdateRole.Text = "Role:";
                btnUpdateEmp.Text = "UPDATE";

                //Delete labels
                gpVerifyDetails.Text = "Verify Employee Details";
                lblDeleteFName.Text = "Employee First Name:";
                lblDeleteLName.Text = "Employee Last Name:";
                lblDeleteAdmin.Text = "Is Admin:";
                lblDeleteClerk.Text = "Is Clerk:";
                lblDeleteJob.Text = "Employee Job:";
                cbConfirm.Text = "Confirmation that it is the correct employee to be deleted";
                btnDeleteEmp.Text = "DELETE";

                //Add Employee
                lblAddFName.Text = "First Name:";
                lblAddLName.Text = "Last Name:";
                lblAddTitle.Text = "Job Title:";
                lblAddRole.Text = "Role:";
                btnAddReset.Text = "RESET";
                btnAdd.Text = "ADD";

                //Search Employee
                gpSearch.Text = "Search by:";
                lblSearchUsername.Text = "Username:";
                lblSearchFName.Text = "First Name:";
                lblSearchLName.Text = "Last Name:";
                btnSearchReset.Text = "RESET";
                gpSort.Text = "Sort by:";
                rdoAsc.Text = "Ascending";
                rdoDes.Text = "Descending";
                gpFilter.Text = "Filter by:";
                rdoAdmin.Text = "Admin users only";
                rdoClerk.Text = "Clerk users only";
                rdoStaff.Text = "Employee staff only";
                btnSearchReset.Text = "RESET";
                btnSearch.Text = "SEARCH";

            }
            else
            {
                //Hoofknoppies
                btnSearch.Text = "SOEK";
                btnAdd.Text = "VOEG TOE";
                btnUpdate.Text = "OPDATERING";
                btnDelete.Text = "VEE";
                btnLanguage.Text = "TAAL";

                //Dateer etikette op
                lblUpdateUsername.Text = "Werknemer Gebruikersnaam:";
                lblUpdateFirstName.Text = "Voornaam:";
                lblUpdateLastName.Text = "Vannaam:";
                lblUpdateJobTitle.Text = "Postitel:";
                lblUpdateRole.Text = "Rol:";
                btnUpdateEmp.Text = "OPDATERING";

                //Vee etikette uit
                gpVerifyDetails.Text = "Verifieer werknemerbesonderhede";
                lblDeleteFName.Text = "Werknemer Voornaam:";
                lblDeleteLName.Text = "Werknemer Van:";
                lblDeleteAdmin.Text = "Is Admin:";
                lblDeleteClerk.Text = "Is Klerk:";
                lblDeleteJob.Text = "Werknemer Pos:";
                cbConfirm.Text = "Bevestiging dat dit die korrekte werknemer is wat uitgevee moet word";
                btnDeleteEmp.Text = "VEE UIT";

                //Voeg werknemer by
                lblAddFName.Text = "Voornaam:";
                lblAddLName.Text = "Vannaam:";
                lblAddTitle.Text = "Postitel:";
                lblAddRole.Text = "Rol:";
                btnAddReset.Text = "TERUGSTEL";
                btnAdd.Text = "VOEG TOE";

                //Soek Werknemer
                gpSearch.Text = "Soek deur:";
                lblSearchUsername.Text = "Gebruikernaam:";
                lblSearchFName.Text = "Voornaam:";
                lblSearchLName.Text = "Vannaam:";
                btnSearchReset.Text = "TERUGSTEL";
                gpSort.Text = "Sorteer volgens:";
                rdoAsc.Text = "Stygend";
                rdoDes.Text = "Daalend";
                gpFilter.Text = "Filter volgens:";
                rdoAdmin.Text = "Slegs administrateur gebruikers";
                rdoClerk.Text = "Slegs klerkgebruikers";
                rdoStaff.Text = "Slegs werknemerspersoneel";
                btnSearchReset.Text = "TERUGSTEL";
                btnSearch.Text = "SOEK";
            }
        }
    }
    }


