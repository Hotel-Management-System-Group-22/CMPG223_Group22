using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HotelManagementSystem.LogIn;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HotelManagementSystem
{
    public partial class Guests : Form
    {
        bool isAfrikaans;
        public Guests(bool isAfrikaans)
        {
            InitializeComponent();
            this.isAfrikaans = isAfrikaans;
            bAfrikaans = isAfrikaans;
            checkLanguage();
        }
        string connection = "Data Source=CAITLIN\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True;";
        //string connection = "Data Source=(Localdb)\\MSSQLLocalDB;Database=Cmpg223;Trusted_Connection=True;";
        bool bAfrikaans = false;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ValidateTextBox(System.Windows.Forms.TextBox textBox)
        {
            if (textBox != null)
            {
                string input = textBox.Text;
                if (!IsTextValid(input))
                {
                    errorProvider1.SetError(textBox, "Input must contain only letters and first letter must be capitilized.");
                }
                else
                {
                    errorProvider1.SetError(textBox, string.Empty);
                }
            }
            else
            {
                errorProvider1.SetError(textBox, "Please fill the textbox");
            }
        }
        private bool IsTextValid(string text)
        {
            // Regular expression to match only letters (Ensures that first letter is capitalized and rest lowercase)
            Regex regex = new Regex("^[A-Z][a-zA-Z]*$");
            return regex.IsMatch(text);
        }
        private void LoadGuestsData(string searchTerm, DataGridView dataGridView, string query)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                // Implement your query execution and data loading logic here.
            }
        }

        private bool IsValidEmail(string email)
        {
            // Simple email validation regex
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            string phonePattern = @"^(\(?0[1-9]\d{1,2}\)?[\s-]?)?\d{3}[\s-]?\d{4}$";

            // Ensure the phone number is exactly 10 digits long after removing non-numeric characters
            string digitsOnly = Regex.Replace(phoneNumber, @"\D", "");

            return digitsOnly.Length == 10 && Regex.IsMatch(phoneNumber, phonePattern);
        }

        private void PopulateUpdateFields(int guestId)
        {
            string query = "SELECT Guest_FName, Guest_LName, Guest_ContactNo, Guest_Email FROM Guest WHERE Guest_ID = @id";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id", guestId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            TxtFName_Update.Text = reader["Guest_FName"].ToString();
                            TxtLName_Update.Text = reader["Guest_LName"].ToString();
                            TxtContactNo_Update.Text = reader["Guest_ContactNo"].ToString();
                            TxtBoxEmail_Update.Text = reader["Guest_Email"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No guest found with the selected ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void PopulateDeleteFields(int guestId)
        {
            string query = "SELECT Guest_FName, Guest_LName, Guest_ContactNo, Guest_Email FROM Guest WHERE Guest_ID = @id";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id", guestId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtFName_Delete.Text = reader["Guest_FName"].ToString();
                            txtLName_delete.Text = reader["Guest_LName"].ToString();
                            txtCellNr_Delete.Text = reader["Guest_ContactNo"].ToString();
                            txtEmail_Delete.Text = reader["Guest_Email"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No guest found with the selected ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void LoadGuests()
        {
            string query = "SELECT * FROM Guest";

            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        DgvGuests.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading guest data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtFName_Update.Clear();
            TxtLName_Update.Clear();
            TxtContactNo_Update.Clear();
            TxtBoxEmail_Update.Clear();
        }

        private void BtnAddPage_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl1.SelectedTab = tbAddGuest;
        }

        private void BtnUpdatePage_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl1.SelectedTab = tbUpdateGuest;
        }

        private void BtnDeleteGuest_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl1.SelectedTab = tbDeleteGuest;
        }

        private void BtnReset_Delet_Click(object sender, EventArgs e)
        {
            //txtFName_Delete.Clear();
           
        }
        private bool IsContactNoOrEmailExists(string contactNo, string email)
        {
            string query = "SELECT COUNT(*) FROM Guest WHERE Guest_ContactNo = @contactNo OR Guest_Email = @email";

            using (var conn = new SqlConnection(connection))
            using (var command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@contactNo", contactNo);
                command.Parameters.AddWithValue("@email", email);

                conn.Open();
                return (int)command.ExecuteScalar() > 0;
            }
        }

        private bool alreadyInDatabase(string fName, string lName)
        {
            string query = "SELECT COUNT(*) FROM Guest WHERE Guest_FName = @fName AND Guest_LName = @lName";
            using (var conn = new SqlConnection(connection))
            using (var command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@fName", fName);
                command.Parameters.AddWithValue("@lName", lName);

                conn.Open();
                return (int)command.ExecuteScalar() > 0;
            }
        }
        private void BtnAddGuest_Click(object sender, EventArgs e)
        {
            // Check for validation errors
            if (string.IsNullOrEmpty(errorProvider1.GetError(TxtFName_Add)) &&
                string.IsNullOrEmpty(errorProvider1.GetError(TxtLName_Add)) &&
                string.IsNullOrEmpty(errorProvider1.GetError(TxtContactNo_Add)) &&
                string.IsNullOrEmpty(errorProvider1.GetError(TxtEmail_Add)))
            {
                if (!string.IsNullOrEmpty(TxtFName_Add.Text) &&
                    !string.IsNullOrEmpty(TxtLName_Add.Text) &&
                    !string.IsNullOrEmpty(TxtContactNo_Add.Text) &&
                    !string.IsNullOrEmpty(TxtEmail_Add.Text))
                {
                    string name = TxtFName_Add.Text;
                    string surname = TxtLName_Add.Text;
                    string contactNo = TxtContactNo_Add.Text;
                    string email = TxtEmail_Add.Text;

                    if (IsContactNoOrEmailExists(contactNo, email))
                    {
                        MessageBox.Show("A guest with this contact number or email already exists.");
                        return; // Exit method to prevent further processing
                    }

                    if (alreadyInDatabase(name, surname))
                    {
                        DialogResult result = MessageBox.Show(
                            "A guest with this name and surname already exists. Are you sure you want to add this guest?",
                            "Warning",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning
                        );
                        if (result == DialogResult.No)
                        {
                            return;
                        }
                    }

                    string query = "INSERT INTO Guest (Guest_FName, Guest_LName, Guest_ContactNo, Guest_Email) VALUES (@name, @surname, @contactNo, @email)";

                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connection))
                        {
                            conn.Open();

                            using (SqlCommand command = new SqlCommand(query, conn))
                            {
                                command.Parameters.AddWithValue("@name", name);
                                command.Parameters.AddWithValue("@surname", surname);
                                command.Parameters.AddWithValue("@contactNo", contactNo);
                                command.Parameters.AddWithValue("@email", email);

                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Guest has been added.");
                                    TxtEmail_Add.Clear();
                                    TxtFName_Add.Clear();
                                    TxtLName_Add.Clear();
                                    TxtContactNo_Add.Clear();
                                    LoadGuests();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to add guest. Please try again.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Please complete all fields.");
                }
            }
            else
            {
                MessageBox.Show("Please ensure all errors are corrected.");
            }
        }


        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // Check if a guest is selected
            if (selectedGuestId == -1)
            {
                MessageBox.Show("No guest selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ensure the confirmation checkbox is checked
            if (!cbConfirmation.Checked)
            {
                MessageBox.Show("Please check the checkbox to confirm this is the correct guest.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Retrieve guest details for confirmation
            //string selectQuery = "SELECT Guest_FName, Guest_LName, Guest_ContactNo, Guest_Email FROM Guest WHERE Guest_ID = @id";
            string guestName = string.Empty;

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

            }

            // Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete " + txtFName_Delete.Text + " " + txtLName_delete.Text +"?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                // Delete the guest
                string deleteQuery = "DELETE FROM Guest WHERE Guest_ID = @id";

                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    //Referencial intergrity D:R so need to check if guest has any bookings, if so, need to restrict the deletion of guest. INTEGRITY of Data!!
                    string checkBookingsQuery = "SELECT COUNT(*) FROM Booking WHERE Guest_ID = @id";
                    using (SqlCommand checkCmd = new SqlCommand(checkBookingsQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@id", selectedGuestId);
                        int bookingCount = (int)checkCmd.ExecuteScalar();

                        if (bookingCount > 0)
                        {
                            if (bAfrikaans == false)
                            {
                                MessageBox.Show("Cannot delete guest as there are existing bookings associated with this guest.", "Delete Restricted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Kan nie gas uitvee nie, want daar is bestaande besprekings wat met hierdie gas verband hou.", "Delete Restricted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }

                    using (SqlCommand command = new SqlCommand(deleteQuery, conn))
                    {
                        command.Parameters.AddWithValue("@id", selectedGuestId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Guest has been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadGuests(); // Reload the guest list to reflect changes
                            ClearDeleteFields(); // Clear the deletion form fields
                            selectedGuestId = -1; // Reset the selected guest ID
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete guest. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void ClearDeleteFields()
        {
            txtFName_Delete.Clear();
            txtLName_delete.Clear();
            txtCellNr_Delete.Clear();
            txtEmail_Delete.Clear();
            cbConfirmation.Checked = false;
        }

        private void RdnBtnAscDelete_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private int selectedGuestId = -1;

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedGuestId == -1)
            {
                MessageBox.Show("No guest selected.");
                return;
            }

            // Populate fields if needed (e.g., when the user first selects a guest to update)
            

            string name = TxtFName_Update.Text.Trim();
            string surname = TxtLName_Update.Text.Trim();
            string contactNo = TxtContactNo_Update.Text.Trim();
            string email = TxtBoxEmail_Update.Text.Trim();

            DialogResult result = MessageBox.Show($"Are you sure you want to change {name} {surname}'s details?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }

            // Validate fields
            bool hasErrors = !string.IsNullOrEmpty(errorProvider1.GetError(TxtFName_Update)) ||!string.IsNullOrEmpty(errorProvider1.GetError(TxtLName_Update)) ||!string.IsNullOrEmpty(errorProvider1.GetError(TxtBoxEmail_Update)) ||!string.IsNullOrEmpty(errorProvider1.GetError(TxtContactNo_Update));

            if (hasErrors)
            {
                MessageBox.Show("Please ensure all errors are corrected.");
                return;
            }

            // Prepare SQL query
            string query = "UPDATE Guest SET Guest_FName = @name, Guest_LName = @surname, Guest_ContactNo = @contactNo, Guest_Email = @email WHERE Guest_ID = @id";

            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@surname", surname);
                        command.Parameters.AddWithValue("@contactNo", contactNo);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@id", selectedGuestId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Guest details have been updated.");
                            LoadGuests(); // Reload the guest list to reflect changes
                        }
                        else
                        {
                            MessageBox.Show("Failed to update guest details. Please try again.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Handle SQL exception
                MessageBox.Show($"An error occurred while updating guest details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void DgvGuests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Ensure valid row and column index
            {
                DataGridViewRow row = DgvGuests.Rows[e.RowIndex];

                if (row.Cells["Guest_ID"].Value != DBNull.Value)
                {
                    selectedGuestId = Convert.ToInt32(row.Cells["Guest_ID"].Value);

                    // Check which tab or mode is active and populate fields accordingly
                    if (tabControl1.SelectedTab == tbUpdateGuest)
                    {
                        PopulateUpdateFields(selectedGuestId);
                    }
                    else if (tabControl1.SelectedTab == tbDeleteGuest)
                    {
                        PopulateDeleteFields(selectedGuestId);
                    }
                }
                else
                {
                    selectedGuestId = -1; // Default to invalid ID if cell value is not present
                }
            }
        }


        private void TxtFName_Add_TextChanged(object sender, EventArgs e)
        {
 ValidateTextBox(TxtFName_Add);
        }

        private void TxtLName_Add_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(TxtLName_Add);
        }

        private void TxtFName_Update_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(TxtFName_Update);
        }

        private void TxtLName_Update_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(TxtLName_Update);
        }

        private void TxtContactNo_Update_TextChanged(object sender, EventArgs e)
        {
            if (!IsValidPhoneNumber(TxtContactNo_Update.Text))
            {
                errorProvider1.SetError(TxtContactNo_Update, "Invalid phone number format.");
                //hasErrors = true;
            }
            else
            {
                errorProvider1.SetError(TxtContactNo_Update, string.Empty);
            }
        }

        private void TxtBoxEmail_Update_TextChanged(object sender, EventArgs e)
        {
            if (!IsValidEmail(TxtBoxEmail_Update.Text))
            {
                errorProvider1.SetError(TxtBoxEmail_Update, "Invalid email format.");
                //hasErrors = true;
            }
            else
            {
                errorProvider1.SetError(TxtBoxEmail_Update, string.Empty);
            }

        }

        private void TxtContactNo_Add_TextChanged(object sender, EventArgs e)
        {
            if (!IsValidPhoneNumber(TxtContactNo_Add.Text))
            {
                errorProvider1.SetError(TxtContactNo_Add, "Invalid phone number format.");
                //hasErrors = true;
            }
            else
            {
                errorProvider1.SetError(TxtContactNo_Add, string.Empty);
            }
        }

        private void TxtEmail_Add_TextChanged(object sender, EventArgs e)
        {
            if (!IsValidEmail(TxtEmail_Add.Text))
            {
                errorProvider1.SetError(TxtEmail_Add, "Invalid email format.");
                //hasErrors = true;
            }
            else
            {
                errorProvider1.SetError(TxtEmail_Add, string.Empty);
            }
        }

        private void Guests_Load(object sender, EventArgs e)
        {
            LoadGuests();
            tabControl1.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string searchBy = "";
            string searchValue = "";
            string sortOrder = "";

            

            // Determine which radio button is checked and set the searchBy and searchValue accordingly
            /*if (rdoLName.Checked)
            {
               // txtLName_Search.Visible = true;
                searchBy = "Guest_LName";
                searchValue = txtLName_Search.Text.Trim();
                
            }
            else if (rdoFName.Checked)
            {
                //txtFName_Search.Visible = true;
                searchBy = "Guest_FName";
                searchValue = txtFName_Search.Text.Trim();
            }
            else if (rdoContact.Checked)
            {   
                //txtContact_Search.Visible = true;
                searchBy = "Guest_ContactNo";
                searchValue = txtContact_Search.Text.Trim();
            }
            else if (rdoEmail.Checked)
            {
                //txtEmail_Search.Visible = true;
                searchBy = "Guest_Email";
                searchValue = txtEmail_Search.Text.Trim();
            }
            */
            // Determine the sort order based on the selected radio button
            if (rdoAsc.Checked)
            {
                sortOrder = "ASC";
            }
            else if (rdoDsc.Checked)
            {
                sortOrder = "DESC";
            }

            // If no search criterion is selected, show an error message
            if (string.IsNullOrEmpty(searchBy))
            {
                MessageBox.Show("Please select a search criterion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // SQL query with the search criteria and sort order
            string query = $"SELECT * FROM Guest WHERE {searchBy} LIKE @SearchValue ORDER BY {searchBy} {sortOrder}";

            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        // Use a parameterized query to prevent SQL injection
                        command.Parameters.AddWithValue("@SearchValue", $"%{searchValue}%");

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Check if results were found
                        if (dataTable.Rows.Count > 0)
                        {
                            DgvGuests.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("No guests found matching the search criteria.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DgvGuests.DataSource = null; // Clear the DataGridView
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl1.SelectedTab = tbSearchGuest;
            //txtLName_Search.Visible = false;
            //txtFName_Search.Visible = false;
           // txtContact_Search.Visible = false;
           // txtEmail_Search.Visible = false;
        }

        private void rdoLName_CheckedChanged(object sender, EventArgs e)
        {
            //txtLName_delete.Visible = true;
        }

        private void rdoFName_CheckedChanged(object sender, EventArgs e)
        {
           // txtFName_Search.Visible=true;
        }

        private void rdoContact_CheckedChanged(object sender, EventArgs e)
        {
            //txtContact_Search.Visible=true;
        }

        private void rdoEmail_CheckedChanged(object sender, EventArgs e)
        {
            //txtEmail_Search.Visible = true;
        }

        private void txtFName_Delete_TextChanged(object sender, EventArgs e)
        {
           // MessageBox.Show("You cannot change textbox value!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtLName_delete_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("You cannot change textbox value!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void txtCellNr_Delete_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("You cannot change textbox value!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void txtEmail_Delete_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            txtEmail_Search.Text = " ";
            txtFName_Search.Text = " ";
            txtLName_Search.Text = " ";
            txtContact_Search.Text = " ";

            LoadGuests();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtLName_Search_TextChanged(object sender, EventArgs e)
        {
            txtEmail_Search.Text = string.Empty;
            txtFName_Search.Text = string.Empty;
            txtContact_Search.Text = string.Empty;

            DataTable dataTable = (DataTable)DgvGuests.DataSource;

            if (dataTable != null)
            {
                // Apply the filter to the DataTable based on the text in txtLName_Search
                string filterExpression = $"Guest_LName LIKE '%{txtLName_Search.Text}%'";
                dataTable.DefaultView.RowFilter = filterExpression;
            }
        }

        private void txtFName_Search_TextChanged(object sender, EventArgs e)
        {
            txtEmail_Search.Text = string.Empty;
            txtLName_Search.Text = string.Empty;
            txtContact_Search.Text = string.Empty;

            DataTable dataTable = (DataTable)DgvGuests.DataSource;

            if (dataTable != null)
            {
                // Apply the filter to the DataTable based on the text in txtLName_Search
                string filterExpression = $"Guest_FName LIKE '%{txtFName_Search.Text}%'";
                dataTable.DefaultView.RowFilter = filterExpression;
            }
        }

        private void txtContact_Search_TextChanged(object sender, EventArgs e)
        {
            txtEmail_Search.Text = string.Empty;
            txtLName_Search.Text = string.Empty;
            txtFName_Search.Text = string.Empty;

            DataTable dataTable = (DataTable)DgvGuests.DataSource;

            if (dataTable != null)
            {
                // Apply the filter to the DataTable based on the text in txtLName_Search
                string filterExpression = $"Guest_ContactNo LIKE '%{txtContact_Search.Text}%'";
                dataTable.DefaultView.RowFilter = filterExpression;
            }
        }

        private void txtEmail_Search_TextChanged(object sender, EventArgs e)
        {
            txtFName_Search.Text = string.Empty;
            txtLName_Search.Text = string.Empty;
            txtContact_Search.Text = string.Empty;

            DataTable dataTable = (DataTable)DgvGuests.DataSource;

            if (dataTable != null)
            {
                // Apply the filter to the DataTable based on the text in txtLName_Search
                string filterExpression = $"Guest_Email LIKE '%{txtEmail_Search.Text}%'";
                dataTable.DefaultView.RowFilter = filterExpression;
            }
        }

        private void rdoAsc_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAsc.Checked)
            {
                DataTable dataTable = (DataTable)DgvGuests.DataSource;

                if (dataTable != null)
                {
                    string sortExpression = "Guest_LName ASC";
                    dataTable.DefaultView.Sort = sortExpression;
                }
            }
        }

        private void rdoDsc_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAsc.Checked)
            {
                DataTable dataTable = (DataTable)DgvGuests.DataSource;

                if (dataTable != null)
                {
                    // Assuming you want to sort by Guest's last name, you can change the column name accordingly
                    string sortExpression = "Guest_LName DESC";
                    dataTable.DefaultView.Sort = sortExpression;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TxtEmail_Add.Text = " ";
            TxtFName_Add.Text = " ";
            TxtLName_Add.Text = " ";
            TxtContactNo_Add.Text = " ";
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            if (isAfrikaans)
            {
                isAfrikaans = false;
                bAfrikaans = false;
            }
            else {
                isAfrikaans=true;
                bAfrikaans=true;
            }
            checkLanguage();
        }

        private void lblDeleteEmail_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormHelper.ShowAppropriateForm(this, LogIn.isAdmin, LogIn.isClerk, bAfrikaans);

        }

        private void checkLanguage() {
            if (isAfrikaans)
            {
                //Buttons
                btnLanguage.Text = "English";
                btnAddReset.Text = "Herstel";
                btnReset.Text = "Herstel";
                btnResetSearch.Text = "Herstel";
                btnSearchPage.Text = "SOEK GAS";
                BtnAddPage.Text = "VOEGBY GAS";
                BtnAddGuest.Text = "Voeg Gas by";
                BtnDelete.Text = "Verwyder";
                BtnDeleteGuestPage.Text = "VERWYDER GAS";
                BtnUpdate.Text = "Opdateer";
                BtnUpdatePage.Text = "OPDATEER GAS";
                //labels
                lblFNameAdd.Text = "Voornaam:";
                lblLNameAdd.Text = "Van:";
                LblContactNo.Text = "Kontak nommer:";
                LblContactNo_Update.Text = "Kontak nommer:";
                LblEmailAddress.Text = "E-pos:";
                LblEmail_Update.Text = "E-pos:";
                LblFName_Update.Text = "Voornaam:";
                LblLName_Update.Text = "Van:";
                lblDeleteEmail.Text = "E-pos:";
                lblDeleteNumber.Text = "Kontak nommer:";
                lblDeleteLName.Text = "Van:";
                lblDeleteFName.Text = "Voornaam:";
                lblSearchNumber.Text = "Kontak nommer:";
                lblSearchEmail.Text = "E-pos:";
                lblSearchFName.Text = "Voornaam:";
                lblSearchLName.Text = "Van:";
                //Other
                cbConfirmation.Text = "Is dit die Gas wat jy wil verwyder?";
                rdoAsc.Text = "Stygend";
                rdoDsc.Text = "Dalend";
                groupBox1.Text = "Bevestig waardes";
                groupBox2.Text = "Soek volgens:";
                groupBox3.Text = "Sorteer by:";
                grpBoxMenu.Text = "Kieslys";


            }
            else
            {
                //Buttons
                btnLanguage.Text = "Afrikaans";
                btnAddReset.Text = "Reset";
                btnReset.Text = "Reset";
                btnResetSearch.Text = "Reset";
                btnSearchPage.Text = "SEARCH GUEST";
                BtnAddGuest.Text = "Add Guest";
                BtnDelete.Text = "Delete";
                BtnDeleteGuestPage.Text = "DELETE GUEST";
                BtnAddPage.Text = "ADD GUEST";
                BtnUpdate.Text = "Update";
                BtnUpdatePage.Text = "UPDATE GUEST";
                //labels
                lblFNameAdd.Text = "First Name:";
                lblLNameAdd.Text = "Last Name:";
                LblContactNo.Text = "Contact Number:";
                LblContactNo_Update.Text = "Contact Number:";
                LblEmailAddress.Text = "Email Address:";
                LblEmail_Update.Text = "Email Address:";
                LblFName_Update.Text = "First Name:";
                LblLName_Update.Text = "Last Name:";
                lblDeleteEmail.Text = "Email Address:";
                lblDeleteNumber.Text = "Contact Number:";
                lblDeleteLName.Text = "Last Name:";
                lblDeleteFName.Text = "First Name:";
                lblSearchNumber.Text = "Contact Number:";
                lblSearchEmail.Text = "Email Address:";
                lblSearchFName.Text = "First Name:";
                lblSearchLName.Text = "Last Name:";
                //Other
                cbConfirmation.Text = "Is this the Guest you want to delete?";
                rdoAsc.Text = "Ascending";
                rdoDsc.Text = "Descending";
                groupBox1.Text = "Confirm Values";
                groupBox2.Text = "Search by:";
                groupBox3.Text = "Sort by:";
                grpBoxMenu.Text = "Menu";

            }
        }
    }
}
