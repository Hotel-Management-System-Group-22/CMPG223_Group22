using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HotelManagementSystem.LogIn;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace HotelManagementSystem
{
    public partial class ManageJobsForm : Form
    {
        Boolean isAfrikaans = false;
        public ManageJobsForm(Boolean isAfrikaans) { 
             this.isAfrikaans = isAfrikaans;
             InitializeComponent();
        }

        //Connection String
        string connectionString = "Server=DESKTOP-P6754UF;Database=223project;Trusted_Connection=True;";
        string sJobID;
        string sJobRate;
        string sJobTitle;
        int selectedId;
        Regex regex = new Regex(@"^[a-zA-Z\s]+$");

        private void ManageJobsForm_Load(object sender, EventArgs e)
        {
            loadData();
            toolTip1.AutoPopDelay = 5000;   //5 seconds
            toolTip1.InitialDelay = 700;    //0.7 seconds
            toolTip1.ReshowDelay = 2000;     //2 seconds
            toolTip1.ShowAlways = true;
            tabcontrol.Visible = false;
            if (isAfrikaans)
            {
                lblAddRate.Text = "Werkskoers: ";
                lblAddTitle.Text = "Werkstitel";
                lblEditRate.Text = "Werkskoers: ";
                lblEditTitle.Text = "Werkstitel";
                lblJobID.Text = "Werk ID";
                lblJobRate.Text = "Werkskoers: ";
                lblJobTitle.Text = "Werkstitel";
                //lblSearchJob.Text = "Soek Werk";
                lblSelectedID.Text = "Geselekteerde ID";
                //lblSelectRecords.Text = "Kies Rekords Hieronder";
                btnAcceptNewJob.Text = "Aanvaar";
                btnAddCancel.Text = "Kanseleer";
                btnAddJob.Text = "Voeg Werk By ";
                btnDeleteJob.Text = "Vee Geselekteerde Werk Uit";
                btnEditJob.Text = "Opdateer Werk ";
                btnReset.Text = "Herstel";
                btnEditAccept.Text = "Aanvaar";
                btnEditCancel.Text = "Kanseleer";
                tabAddJob.Text = "Voeg Werkinlighting by";
                tabEditJob.Text = "Wysig Werkinligting";

                toolTip1.SetToolTip(btnAcceptNewJob, "Kliek om die nuwe werk te aanvaar.");
                toolTip1.SetToolTip(btnAddCancel, "Kliek om die toevoeging van werk te kanselleer.");
                toolTip1.SetToolTip(btnAddJob, "Kliek om 'n nuwe werk by te voeg.");
                toolTip1.SetToolTip(btnDeleteJob, "Kliek om die geselekteerde werk uit te vee.");
                toolTip1.SetToolTip(btnEditJob, "Kliek om die geselekteerde werk op te dateer.");
                toolTip1.SetToolTip(btnReset, "Kliek om die soekveld terug te stel.");
                toolTip1.SetToolTip(btnEditAccept, "Kliek om die gewysigde werk te aanvaar.");
                toolTip1.SetToolTip(btnEditCancel, "Kliek om die gewysigde van die werk te kanselleer.");

                toolTip1.SetToolTip(txtAddJobRate, "Voer die tarief vir die nuwe werk in.");
                toolTip1.SetToolTip(txtAddJobTitle, "Voer die titel vir die nuwe werk in.");
                toolTip1.SetToolTip(txtEditJobRate, "Voer die nuwe tarief vir die geselekteerde werk in.");
                toolTip1.SetToolTip(txtEditJobTitle, "Voer die nuwe titel vir die geselekteerde werk in.");
                toolTip1.SetToolTip(txtJobID, "Voer die Job ID in waarna jy soek.");
                toolTip1.SetToolTip(txtJobRate, "Voer die tarief in waarna jy soek.");
                toolTip1.SetToolTip(txtJobTitle, "Voer die titel in waarna jy soek.");


            }
            else if (isAfrikaans == false)
            {
                lblAddRate.Text = "Job Rate: ";
                lblAddTitle.Text = "Job Title: ";
                lblEditRate.Text = "Job Rate: ";
                lblEditTitle.Text = "Job Title: ";
                lblJobID.Text = "Job ID: ";
                lblJobRate.Text = "Job Rate: ";
                lblJobTitle.Text = "Job Title: ";
                //lblSearchJob.Text = "Search Job: ";
                lblSelectedID.Text = "Selected ID: ";
                //lblSelectRecords.Text = "Select Records Below";
                btnAcceptNewJob.Text = "Accept";
                btnAddCancel.Text = "Cancel";
                btnAddJob.Text = "Add Job";
                btnDeleteJob.Text = "Delete Selected Job";
                btnEditJob.Text = "Update Job";
                btnReset.Text = "Reset";
                btnEditAccept.Text = "Accept";
                btnEditCancel.Text = "Cancel";
                tabAddJob.Text = "Add Job Info";
                tabEditJob.Text = "Edit Job Info";

                toolTip1.SetToolTip(btnAcceptNewJob, "Click to accept the new job.");
                toolTip1.SetToolTip(btnAddCancel, "Click to cancel adding the job.");
                toolTip1.SetToolTip(btnAddJob, "Click to add a new job.");
                toolTip1.SetToolTip(btnDeleteJob, "Click to delete the selected job.");
                toolTip1.SetToolTip(btnEditJob, "Click to edit the selected job.");
                toolTip1.SetToolTip(btnReset, "Click to reset the search field.");
                toolTip1.SetToolTip(btnEditAccept, "Click to accept the modified job.");
                toolTip1.SetToolTip(btnEditCancel, "Click to cancel editing the job.");

                toolTip1.SetToolTip(txtAddJobRate, "Enter the rate for the new job.");
                toolTip1.SetToolTip(txtAddJobTitle, "Enter the title for the new job.");
                toolTip1.SetToolTip(txtEditJobRate, "Enter the new rate for the selected job.");
                toolTip1.SetToolTip(txtEditJobTitle, "Enter the new title for the selected job.");
                toolTip1.SetToolTip(txtJobID, "Enter the Job ID you seek");
                toolTip1.SetToolTip(txtJobRate, "Enter the Rate you seek ");
                toolTip1.SetToolTip(txtJobTitle, "Enter the Title you seek");

            }
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
                    if (isAfrikaans) {
                        MessageBox.Show("Fout het voorgekom: " + ex.Message);
                    }
                    else if(isAfrikaans == false){ 
                        MessageBox.Show("An error occurred: " + ex.Message); 
                    }
                    
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
            if (regex.IsMatch(txtAddJobTitle.Text) || txtAddJobTitle.Text == string.Empty)
            {
                // The input is a valid integer
                sJobTitle = txtAddJobTitle.Text;
            }
            else
            {
                // The input is not a valid integer
                if (isAfrikaans)
                {
                     MessageBox.Show("Voer asseblief 'n geldige alfabetiese letter in.", "Ongeldige Invoer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (isAfrikaans == false)
                {
                    MessageBox.Show("Please enter a valid Alphabetical letter.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                if (isAfrikaans)
                {
                    MessageBox.Show("Voer asseblief 'n geldige alfabetiese letter in.", "Ongeldige Invoer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (isAfrikaans == false)
                {
                    MessageBox.Show("Please enter a valid Alphabetical letter.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                DialogResult result = System.Windows.Forms.DialogResult.Yes;
                if (isAfrikaans)
                {
                    result = MessageBox.Show("Is jy seker jy wil hierdie rekord byvoeg", "Bevestiging", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                else if (isAfrikaans == false)
                {
                    result = MessageBox.Show("Are you sure you want to Add this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
               
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
                                if (isAfrikaans)
                                {
                                    Console.WriteLine("Invoeging was suksesvol.");
                                }
                                else if (isAfrikaans == false)
                                {
                                    Console.WriteLine("Insert successful.");
                                }
                                loadData();
                            }
                            else
                            {
                                if (isAfrikaans)
                                {
                                    Console.WriteLine("Invoeging het misluk.");
                                }
                                else if (isAfrikaans == false)
                                {
                                    Console.WriteLine("Insert failed.");
                                }
                                
                            }
                        }
                        catch (Exception ex)
                        {
                            if (isAfrikaans)
                            {
                                MessageBox.Show("Fout het voorgekom: " + ex.Message);
                            }
                            else if (isAfrikaans == false)
                            {
                                MessageBox.Show("An error occurred: " + ex.Message);
                            }
                        }
                    }
                    lblSelectedID.Visible = false;
                    txtAddJobTitle.Text = "";
                    txtAddJobRate.Text = "";

                }
            }
            else
            {
                if (isAfrikaans)
                {
                    MessageBox.Show("Veld kan nie leeg wees nie");
                }
                else if (isAfrikaans == false)
                {
                    MessageBox.Show("Fields cannot be Empty");
                }
                
            }
        }

        private void btnAddJob_Click_1(object sender, EventArgs e)
        {
            tabcontrol.Visible = true;
            tabcontrol.SelectedTab = tabAddJob;
        }

        private void btnEditJob_Click(object sender, EventArgs e)
        {
            
            if (dgvJobList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvJobList.SelectedRows[0];
                selectedId = Convert.ToInt32(selectedRow.Cells["Job_ID"].Value);
                if (isAfrikaans)
                {
                    lblSelectedID.Text = "Geselekteerde ID: " + selectedId;
                }
                else if (isAfrikaans == false)
                {
                    lblSelectedID.Text = "Selected ID: " + selectedId;
                }
                tabcontrol.Visible = true;
                tabcontrol.SelectedTab = tabEditJob;
                lblSelectedID.Visible = true;
            }
            else
            {
                if (isAfrikaans)
                {
                    MessageBox.Show("Geen rekord gekies nie Kies asseblief watter werk you wil wysig");
                }
                else if (isAfrikaans == false)
                {
                    MessageBox.Show("No records selected. Please select which job you would like to edit");
                }
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

                DialogResult result = System.Windows.Forms.DialogResult.Yes;
                if (isAfrikaans)
                {
                    result = MessageBox.Show("Is jy seker jy wil hierdie rekord wysig", "Bevestiging", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                else if (isAfrikaans == false)
                {
                    result = MessageBox.Show("Are you sure you want to edit this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }

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

                                if (isAfrikaans)
                                {
                                    Console.WriteLine("Invoeging was suksesvol.");
                                }
                                else if (isAfrikaans == false)
                                {
                                    Console.WriteLine("Insert successful.");
                                }
                                loadData();
                            }
                            else
                            {
                                if (isAfrikaans)
                                {
                                    Console.WriteLine("Invoeging het misluk.");
                                }
                                else if (isAfrikaans == false)
                                {
                                    Console.WriteLine("Insert failed.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            if (isAfrikaans)
                            {
                                MessageBox.Show("Fout het voorgekom: " + ex.Message);
                            }
                            else if (isAfrikaans == false)
                            {
                                MessageBox.Show("An error occurred: " + ex.Message);
                            }
                        }
                    }

                }
                lblSelectedID.Visible = false;
                txtEditJobTitle.Text = "";
                txtEditJobRate.Text = "";
            }
            else
            {
                if (isAfrikaans)
                {
                    MessageBox.Show("Veld kan nie leeg wees nie");
                }
                else if (isAfrikaans == false)
                {
                    MessageBox.Show("Fields cannot be Empty");
                }
            }
            loadData();
        }

        private void btnAddCancel_Click_1(object sender, EventArgs e)
        {
            txtAddJobTitle.Text = "";
            txtAddJobRate.Text = "";
        }

        private void btnDeleteJob_Click(object sender, EventArgs e)
        {
            if (dgvJobList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvJobList.SelectedRows[0];
                selectedId = Convert.ToInt32(selectedRow.Cells["Job_ID"].Value);

                DialogResult result = System.Windows.Forms.DialogResult.Yes;
                if (isAfrikaans)
                {
                    result = MessageBox.Show("Is jy seker jy wil hierdie werk en alle geassosieerde werknemers uitvee? \nWerk ID:" + selectedId, "Bevestiging", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                else if (isAfrikaans == false)
                {
                    result = MessageBox.Show("Are you sure you want to delete this job and all associated employees? \nJob ID: " + selectedId, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }

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
                            //Referencial intergrity D:R so need to check if guest has any bookings, if so, need to restrict the deletion of guest. INTEGRITY of Data!!
                            string checkEmployeeJobQuery = "SELECT COUNT(*) FROM Employee WHERE Job_ID = @id";
                            using (SqlCommand checkCmd = new SqlCommand(checkEmployeeJobQuery, connection))
                            {
                                checkCmd.Parameters.AddWithValue("@id", selectedId);
                                int bookingCount = (int)checkCmd.ExecuteScalar();

                                if (bookingCount > 0)
                                {
                                    if (isAfrikaans == false)
                                    {
                                        MessageBox.Show("Cannot delete job as there are existing employees associated with this job.", "Delete Restricted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Kan nie die posisie verwyder nie, aangesien daar bestaande werknemers aan hierdie posisie verbind is", "Verwyder Beperk", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }
                                }
                            }

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@JobID", selectedId);

                                int rowsAffected = command.ExecuteNonQuery();
                                if (isAfrikaans)
                                {
                                    MessageBox.Show(rowsAffected > 0
                                        ? "Werk en geassosieerde werknemers suksesvol uitgevee."
                                        : "Geen rekord gevind met die gespesifiseerde Werk ID nie.");
                                }
                                else
                                {
                                    MessageBox.Show(rowsAffected > 0
                                        ? "Job and associated employees deleted successfully."
                                        : "No record found with the specified Job ID.");
                                }

                            }
                            loadData();
                        }
                        catch (Exception ex)
                        {
                            if (isAfrikaans)
                            {
                                MessageBox.Show("Fout het voorgekom: " + ex.Message);
                            }
                            else if (isAfrikaans == false)
                            {
                                MessageBox.Show("An error occurred: " + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    if (isAfrikaans)
                    {
                        MessageBox.Show("Aksie gekanselleer.");
                    }
                    else
                    {
                        MessageBox.Show("Action canceled.");
                    }

                }
            }
            else
            {
                if (isAfrikaans)
                {
                    MessageBox.Show("Geen rekord gekies nie. Kies asseblief 'n werk om uit te vee.");
                }
                else
                {
                    MessageBox.Show("No record selected. Please select a job to delete.");
                }

            }
        }

        private void txtEditJobRate_Validating(object sender, CancelEventArgs e)
        {
           /* string pattern = @"^-?\d+(\,\d+)?$"; // Allows positive and negative decimals with a comma separator
            if (!Regex.IsMatch(txtEditJobRate.Text, pattern))
            {
                errorProvider1.SetError(txtEditJobRate, "Please enter a valid decimal number.");
                e.Cancel = true; // Prevents the user from leaving the TextBox if validation fails
            }
            else
            {
                errorProvider1.SetError(txtEditJobRate, string.Empty); // Clears the error if the input is valid
            }*/
        }

        private void txtAddJobRate_Validating(object sender, CancelEventArgs e)
        {
            /*string pattern = @"^-?\d+(\,\d+)?$"; // Allows positive and negative decimals with a comma separator
            if (!Regex.IsMatch(txtAddJobRate.Text, pattern))
            {
                errorProvider2.SetError(txtAddJobRate, "Please enter a valid decimal number.");
                e.Cancel = true; // Prevents the user from leaving the TextBox if validation fails
            }
            else
            {
                errorProvider2.SetError(txtAddJobRate, string.Empty); // Clears the error if the input is valid
            }*/
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
                if (isAfrikaans)
                {
                    MessageBox.Show("Voer asseblief 'n geldige heelgetal in.", "Ongeldige Invoer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

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
            if (regex.IsMatch(txtJobTitle.Text) || txtJobTitle.Text == string.Empty)
            {
                // The input is a valid integer
                UpdateEmployeeDataGridView(txtJobTitle.Text, dgvJobList, "SELECT * FROM Job WHERE Job_Title LIKE @searchTerm");
                sJobTitle = txtJobTitle.Text;
            }
            else
            {
                // The input is not a valid integer
                if (isAfrikaans)
                {
                    MessageBox.Show("Voer asseblief 'n geldige alfabetiese letter in.", "Ongeldige Invoer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Please enter a valid alphabetical letter.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                if (isAfrikaans)
                {
                    MessageBox.Show("Voer asseblief 'n geldige heelgetal in.", "Ongeldige Invoer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                txtJobRate.Text = sJobRate;
                txtJobRate.Select(txtJobRate.Text.Length, 0);

            }
        }

        private void txtEditJobTitle_TextChanged(object sender, EventArgs e)
        {
            if (regex.IsMatch(txtEditJobTitle.Text) || txtEditJobTitle.Text == string.Empty)
            {
                // The input is a valid integer
                sJobTitle = txtEditJobTitle.Text;
            }
            else
            {
                // The input is not a valid integer
                if (isAfrikaans)
                {
                    MessageBox.Show("Voer asseblief 'n geldige alfabetiese letter in.", "Ongeldige Invoer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Please enter a valid alphabetical letter.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                if (isAfrikaans)
                {
                    MessageBox.Show("Voer asseblief 'n geldige heelgetal in.", "Ongeldige Invoer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                txtEditJobRate.Text = sJobRate;
                txtEditJobRate.Select(txtEditJobRate.Text.Length, 0);

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            CheckIn newform = new CheckIn();
            newform.Show();
            tabcontrol.Visible = false;
            txtAddJobRate.Text = "";
            txtAddJobTitle.Text = "";
            txtEditJobRate.Text = "";
            txtEditJobTitle.Text = "";
            txtJobRate.Text = "";
            txtJobTitle.Text = "";
            txtJobID.Text = "";
            if (isAfrikaans)
            {
                lblSelectedID.Text = "Geselekteerde ID: ";
            }
            else
            {
                lblSelectedID.Text = "Selected ID: ";
            }

        }

        private void lblSelectedID_Click(object sender, EventArgs e)
        {

        }

        private void dgvJobList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvJobList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvJobList.SelectedRows[0];
                selectedId = Convert.ToInt32(selectedRow.Cells["Job_ID"].Value);
                if (isAfrikaans) {
                    lblSelectedID.Text = "Geselekteerde ID: " + selectedId;
                }
                else if (isAfrikaans == false) {
                    lblSelectedID.Text = "Selected ID: " + selectedId;
                }
                
                tabcontrol.SelectedTab = tabEditJob;
                lblSelectedID.Visible = true;
            }
        }

        private void PanelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabEditJob_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormHelper.ShowAppropriateForm(this, LogIn.isAdmin, LogIn.isClerk);

        }
    }
}

