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
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using BCrypt.Net;

namespace HotelManagementSystem
{
    public partial class LogIn : Form
    {
        string connection = "Data Source=CAITLIN\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True;";
        private bool bAfrikaans = false;
        public LogIn()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '•';
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            string query = "SELECT Employee_Password FROM Employee WHERE Employee_Username = @username";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@username", username);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string storedPassword = reader["Employee_Password"].ToString();

                        if (storedPassword == password)
                        {
                            if (IsFirstTimeLogin(storedPassword))
                            {
                                // Redirect to password change form
                                UpdatePassword changePasswordForm = new UpdatePassword(username);
                                
                                changePasswordForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                // Proceed to the main application
                                Employees mainForm = new Employees();
                                mainForm.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            if (bAfrikaans)
                            {
                                MessageBox.Show("Invalid password.");
                            }
                            else
                            {
                                MessageBox.Show("Ongeldige wagwoord.");
                            }
                        }
                    }
                    else
                    {
                        if (bAfrikaans)
                        {
                            MessageBox.Show("Invalid username.");
                        }
                        else
                        {
                            MessageBox.Show("Ongeldige gebruikernaam.");
                        }
                    }
                }
            }
        }

        // Check if the password is the default (first login)
        private bool IsFirstTimeLogin(string storedPassword)
        {
            return storedPassword.Length == 12;
        }

        private void pbViewPassword_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
            pbViewPassword.Visible = false;
            pbNotView.Visible = true;
            
        }

        private void pbNotView_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '•';
            pbViewPassword.Visible = true;
            pbNotView.Visible = false;
        }
        public string GetUsername()
        {
            return txtUsername.Text.Trim();
        }
        private void btnLanguage_Click(object sender, EventArgs e)
        {
            if (bAfrikaans == false)
            {
                lblUsername.Text = "Gebruikersnaam";
                lblPassword.Text = "Wagwoord";
                btnLogin.Text = "AANMEL";
                btnLanguage.Text = "TAAL";
            }
            else
            {
                lblUsername.Text = "Username";
                lblPassword.Text = "Password";
                btnLogin.Text = "LOGIN";
                btnLanguage.Text = "LANGUAGE";
            }
        }
    }
}
