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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using BCrypt.Net;

namespace HotelManagementSystem
{
    public partial class LogIn : Form
    {
        string connection = "Data Source=CAITLIN\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True;";
        private bool bAfrikaans = false;
        public static bool isAdmin = false;
        public static bool isClerk = false;
        public LogIn(Boolean isAfrikaans)
        {
            InitializeComponent();
            txtPassword.PasswordChar = '•';
            bAfrikaans = isAfrikaans;
            checkLanguage();
            //this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
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
                                reader.Close(); // Close the reader before executing another command

                                string roleQuery = "SELECT is_Admin_YN, is_Clerk_YN FROM Employee WHERE Employee_Username = @username AND Employee_Password = @password";

                                using (SqlCommand roleCmd = new SqlCommand(roleQuery, conn))
                                {
                                    roleCmd.Parameters.AddWithValue("@username", username);
                                    roleCmd.Parameters.AddWithValue("@password", password); // Ensure this is hashed if used

                                    using (SqlDataReader roleReader = roleCmd.ExecuteReader())
                                    {
                                        if (roleReader.Read())
                                        {
                                            isAdmin = roleReader.GetBoolean(0); // is_Admin_YN
                                            isClerk = roleReader.GetBoolean(1); // is_Clerk_YN
                                        }
                                    }
                                }
                                FormHelper.ShowAppropriateForm(this, LogIn.isAdmin, LogIn.isClerk, bAfrikaans);


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
        //Stack Overflow TEST!!!
        public static class FormHelper
        {
            public static void ShowAppropriateForm(Form currentForm, bool isAdmin, bool isClerk, bool isAfrikaans)
            {
                if (isAdmin)
                {
                    AdminMenu adminMenu = new AdminMenu(isAfrikaans);
                    adminMenu.Show();
                    currentForm.Hide();
                }
                else if (isClerk)
                {
                    ClerkMenu clerkMenu = new ClerkMenu(isAfrikaans);
                    clerkMenu.Show();
                    currentForm.Hide();
                }
                else
                {
                    MessageBox.Show("Access denied. You do not have the necessary permissions.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLanguage_Click_1(object sender, EventArgs e)
        {
            if (bAfrikaans == false)
            {
                bAfrikaans = true;
            }
            else if (bAfrikaans == true) {
                bAfrikaans = false;
            }
            checkLanguage();
        }

        private void checkLanguage() {
            if (bAfrikaans == false)
            {
                lblUsername.Text = "Gebruikersnaam";
                lblPassword.Text = "Wagwoord";
                btnLogin.Text = "AANMEL";
                btnLanguage.Text = "English";
            }
            else
            {
                lblUsername.Text = "Username";
                lblPassword.Text = "Password";
                btnLogin.Text = "LOGIN";
                btnLanguage.Text = "Afrikaans";
            }
        }
    }
}
