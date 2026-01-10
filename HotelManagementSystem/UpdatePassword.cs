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
using System.Collections;

namespace HotelManagementSystem
{
    public partial class UpdatePassword : Form
    {
        private string username;
        private bool bAfrikaans = false;

        public UpdatePassword(string userName)
        {
            InitializeComponent();
            this.username = userName;  // Initialize with the username passed from the LogIn form
           // this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
        }
        string connectiong = "Data Source=CAITLIN\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True;";
       // string connectiong = "Data Source=(Localdb)\\MSSQLLocalDB;Database=Cmpg223;Trusted_Connection=True;";
        private void Update_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn(bAfrikaans);

            string username = login.GetUsername();
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtNewPassword2.Text.Trim();

            string specialCharacters = "!@#&*_?";
            string numbers = "123456789";
            int specialCharFound = 0;
            int numFound = 0;

            foreach (char currentChar in newPassword)
            {
                if (specialCharacters.Contains(currentChar))
                {
                    specialCharFound++;
                }
                if (numbers.Contains(currentChar))
                {
                    numFound++;
                }
            }

            if (specialCharFound < 1)
            {
                if (bAfrikaans)
                {
                    errorProvider1.SetError(txtNewPassword, "Password must contain at least one special character.");
                }
                else
                {
                    errorProvider1.SetError(txtNewPassword, "Wagwoord moet ten minste een spesiale karakter bevat.");
                }
            }
            else
            {
                errorProvider1.Clear();
                if (numFound < 2)
                {
                    if (bAfrikaans)
                    {
                        errorProvider2.SetError(txtNewPassword, "Password must contain at least 2 digits.");
                    }
                    else
                    {
                        errorProvider2.SetError(txtNewPassword, "Wagwoord moet ten minste 2 syfers bevat.");
                    }
                }
                else
                {
                    errorProvider2.Clear();
                    if (newPassword.Length < 8 || newPassword.Length > 12)
                    {
                        if (bAfrikaans)
                        {
                            errorProvider3.SetError(txtNewPassword, "Password must be between 8 and 12 characters.");
                        }
                        else
                        {
                            errorProvider3.SetError(txtNewPassword, "Wagwoord moet tussen 8 en 12 karakters wees.");
                        }
                    }
                    else
                    {
                        errorProvider3.Clear();
                        if (newPassword == confirmPassword)
                        {
                            string query = "UPDATE Employee SET Employee_Password = @newPassword WHERE Employee_Username = @username";

                            using (SqlConnection conn = new SqlConnection(connectiong))
                            {
                                conn.Open();
                                using (SqlCommand command = new SqlCommand(query, conn))
                                {
                                    command.Parameters.AddWithValue("@newPassword", newPassword);
                                    command.Parameters.AddWithValue("@username", this.username);

                                    command.ExecuteNonQuery();
                                    if (bAfrikaans)
                                    {
                                        MessageBox.Show("Password has been changed.");
                                        login.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Wagwoord is verander.");
                                        login.Show();
                                        this.Hide();
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (bAfrikaans)
                            {
                                MessageBox.Show("Passwords do not match.");
                            }
                            else
                            {
                                MessageBox.Show("Wagwoorde stem nie ooreen nie.");
                            }
                        }
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btnLanguage_Click(object sender, EventArgs e)
        {
            if (bAfrikaans == false)
            {
                lblNewPassword.Text = "Nuwe wagwoord";
                lblConfirmNewPassword.Text = "Bevestig nuwe wagwoord";
                btnUpdatePassword.Text = "DATEER WAGWOORD OP";
                btnLanguage.Text = "TAAL";
            }
            else
            {
                lblNewPassword.Text = "New Password";
                lblConfirmNewPassword.Text = "Confirm new password";
                btnUpdatePassword.Text = "UPDATE";
                btnLanguage.Text = "LANGUAGE";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLanguage_Click_1(object sender, EventArgs e)
        {
            if (bAfrikaans)
            {
                bAfrikaans = false;
            }
            else
            {
                bAfrikaans = true;
            }
            checkLanguage();
        }

        private void checkLanguage()
        {
            if (bAfrikaans)
            {
                btnLanguage.Text = "English";
                btnUpdatePassword.Text = "Odateer wagwoord";
                lblConfirmNewPassword.Text = "Bevestig wagwoord:";
                lblNewPassword.Text ="Nuwe wagwoord:";
                
            }
            else
            {
                btnLanguage.Text = "Afrikaans";
                btnUpdatePassword.Text = "Update Password";
                lblConfirmNewPassword.Text = "Confirm Password:";
                lblNewPassword.Text = "New Password:";


            }
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNewPassword2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
