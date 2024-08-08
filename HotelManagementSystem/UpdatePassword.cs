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

            if (newPassword.Length >= 8 && newPassword.Length < 12)
            {
                if (newPassword == confirmPassword)
                {
                    LogIn login = new LogIn();
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
            else 
            {
                MessageBox.Show("Password length must be between 8 - 12 digits");
            }
        }
    }
}
