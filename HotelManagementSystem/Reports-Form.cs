using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HotelManagementSystem.LogIn;

namespace HotelManagementSystem
{
    public partial class ReportsForm : Form
    {
        DateTime startDate;
        DateTime endDate;
        Boolean isAfrikaans = false;
        // string connectionString = "Data Source=CAITLIN\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True;";
        string connectionString = "Data Source=(Localdb)\\MSSQLLocalDB;Database=Cmpg223;Trusted_Connection=True;";
        public ReportsForm(Boolean isAfrikaans)
        {
            this.isAfrikaans=isAfrikaans;
            InitializeComponent();
            loadData();
            startDate = dtpStart.Value;
            endDate = dtpEnd.Value;
            checkLanguage();
            lblHeading.Visible = false;
            
        }

        private void loadData()
        {
            // Define the query to retrieve data from the Booking table
            string query = "SELECT * FROM Booking";

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
                    dgvBookings.DataSource = dataTable;  // Assuming dgvBookingList is the DataGridView for Booking
                }
                catch (Exception ex)
                {
                    if (isAfrikaans)
                    {
                        MessageBox.Show("Daar het 'n fout voorgekom: " + ex.Message);
                    }
                    else
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }

                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            if (cbReports.SelectedIndex == 0 || cbReports.SelectedIndex == 1)
            {
                if (cbReports.SelectedIndex == 0) 
                {
                    if (endDate > startDate)
                    {
                        string query = @"
    SELECT 
        COUNT(*) AS TotalCheckOuts
    FROM 
        Booking
    WHERE 
        Guest_Departure BETWEEN @StartDate AND @EndDate;";

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@StartDate", startDate);
                            command.Parameters.AddWithValue("@EndDate", endDate);

                            try
                            {
                                connection.Open();
                                SqlDataAdapter adapter = new SqlDataAdapter(command);
                                DataTable dataTable = new DataTable();
                                adapter.Fill(dataTable);

                                // Bind the DataTable to the DataGridView
                                dgvBookings.DataSource = dataTable;

                                // Format the columns in dgvReport
                                dgvBookings.Columns["TotalCheckOuts"].HeaderText = "Total Number of Check-Outs";
                                lblHeading.Visible = true;

                                if (isAfrikaans)
                                {
                                    lblHeading.Text = "Versoek  Wys " + cbReports.SelectedItem.ToString() + " tussen " + startDate.Date.ToString("yyyy-MM-dd") + " - " + endDate.Date.ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    lblHeading.Text = "Report Showing " + cbReports.SelectedItem.ToString() + " between " + startDate.Date.ToString("yyyy-MM-dd") + " - " + endDate.Date.ToString("yyyy-MM-dd");
                                }
                            }
                            catch (Exception ex)
                            {
                                if (isAfrikaans)
                                {
                                    MessageBox.Show("Daar het 'n fout voorgekom: " + ex.Message);
                                }
                                else
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
                            MessageBox.Show("Eind datum kan nie voor die begin datum wees nie");
                        }
                        else
                        {
                            MessageBox.Show("End date cannot be before start date");
                        }
                    }
                } 
                else if (cbReports.SelectedIndex == 1) 
                {
                    string query = @"
    WITH WeeklyBookings AS (
        SELECT 
            DATEPART(YEAR, Guest_Arrival) AS Year,
            DATEPART(WEEK, Guest_Arrival) AS Week,
            DATEPART(MONTH, Guest_Arrival) AS Month,
            COUNT(*) AS TotalGuests
        FROM 
            Booking
        WHERE 
            Guest_Arrival BETWEEN @StartDate AND @EndDate
        GROUP BY 
            DATEPART(YEAR, Guest_Arrival), 
            DATEPART(WEEK, Guest_Arrival), 
            DATEPART(MONTH, Guest_Arrival)
    )
    SELECT TOP 10
        Year,
        Month,
        Week,
        TotalGuests AS [Number of Guests]
    FROM 
        WeeklyBookings
    ORDER BY 
        TotalGuests DESC;";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@StartDate", startDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);

                        try
                        {
                            connection.Open();
                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Bind the DataTable to the DataGridView
                            dgvBookings.DataSource = dataTable;

                            // Format the columns in dgvReport
                            dgvBookings.Columns["Year"].HeaderText = "Year";
                            dgvBookings.Columns["Month"].HeaderText = "Month";
                            dgvBookings.Columns["Week"].HeaderText = "Week";
                            dgvBookings.Columns["Number of Guests"].HeaderText = "Number of Guests";
                        }
                        catch (Exception ex)
                        {
                            if (isAfrikaans)
                            {
                                MessageBox.Show("Daar het 'n fout voorgekom: " + ex.Message);
                            }
                            else
                            {
                                MessageBox.Show("An error occurred: " + ex.Message);
                            }

                        }
                    }

                }
            }
            else {
                if (isAfrikaans)
                {
                    MessageBox.Show("Kies asseblief watter verslag jy wil hê.");
                }
                else
                {
                    MessageBox.Show("Please select which report you would like.");
                }

            }
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            startDate = dtpStart.Value;
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            endDate = dtpEnd.Value;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            loadData();
            lblHeading.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgvBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormHelper.ShowAppropriateForm(this, LogIn.isAdmin, LogIn.isClerk, isAfrikaans);

        }

        private void checkLanguage() {
            if (isAfrikaans)
            {
                lblEndDate.Text = "Einddatum:";
                lblReportType.Text = "Verslagtipe: ";
                lblStartDate.Text = "Begin datum: ";
                cbReports.Items.Clear();
                cbReports.Items.Add("Gaste Het Uitgecheck");
                cbReports.Items.Add("Top 10 Week Verkeer");
                btnCancel.Text = "Kanselleer";
                btnGenerateReport.Text = "Genereer Verslag";
                toolTip1.SetToolTip(cbReports, "Kies 'n verslag uit die lys.");
                toolTip1.SetToolTip(btnCancel, "Klik om die operasie te kanselleer.");
                toolTip1.SetToolTip(btnGenerateReport, "Klik om die geselekteerde verslag te genereer.");
                toolTip1.SetToolTip(dtpStart, "Kies die begindatum.");
                toolTip1.SetToolTip(dtpEnd, "Kies die einddatum.");
                grpBxReports.Text = "Versoek Verslag";
            }
            else
            {
                grpBxReports.Text = "Request Report";
                lblEndDate.Text = "End Date:";
                lblReportType.Text = "Report Type: ";
                lblStartDate.Text = "Start Date: ";
                cbReports.Items.Clear();
                cbReports.Items.Add("Guests Checked Out");
                cbReports.Items.Add("Top 10 Week Traffic");
                btnCancel.Text = "Cancel";
                btnGenerateReport.Text = "Generate Report";
                toolTip1.SetToolTip(cbReports, "Select a report from the list.");
                toolTip1.SetToolTip(btnCancel, "Click to cancel the operation.");
                toolTip1.SetToolTip(btnGenerateReport, "Click to generate the selected report.");
                toolTip1.SetToolTip(dtpStart, "Select the start date.");
                toolTip1.SetToolTip(dtpEnd, "Select the end date.");

            }
        }

        private void btnlanguage_Click(object sender, EventArgs e)
        {
            if (isAfrikaans)
            {
                isAfrikaans = false;
            }
            else
            {
                isAfrikaans = true;
            }
            checkLanguage();
        }
    }
}
