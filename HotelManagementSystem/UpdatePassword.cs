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
        public UpdatePassword()
        {
            InitializeComponent();
        }
        string connection = "Data Source=CAITLIN\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True;";
        LogIn login = new LogIn();
        private void Update_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text.Trim();
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
                errorProvider1.SetError(txtNewPassword, "Password must contain at least one special character.");
            }
            else
            {
                errorProvider1.Clear();
                if (numFound < 2)
                {
                    errorProvider2.SetError(txtNewPassword, "Password must contain at least 2 digits.");
                }
                else
                {
                    errorProvider2.Clear();
                    if (newPassword.Length < 8 || newPassword.Length > 12)
                    {
                        errorProvider3.SetError(txtNewPassword, "Password must be between 8 and 12 characters.");
                    }
                    else
                    {
                        errorProvider3.Clear();
                        if (newPassword == confirmPassword)
                        {
                            string query = "UPDATE Employee SET Employee_Password = @newPassword WHERE Employee_Username = @username";

                            using (SqlConnection conn = new SqlConnection(connection))
                            {
                                conn.Open();
                                using (SqlCommand command = new SqlCommand(query, conn))
                                {
                                    command.Parameters.AddWithValue("@newPassword", newPassword);
                                    command.Parameters.AddWithValue("@username", username);

                                    command.ExecuteNonQuery();
                                    MessageBox.Show("Password has been changed.");
                                    login.Show();
                                    this.Hide();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Passwords do not match.");
                        }
                    }
                }
            }
        }
    }
}
