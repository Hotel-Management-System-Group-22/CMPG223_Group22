using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HotelManagementSystem
{
    public partial class Guests : Form
    {
        public Guests()
        {
            InitializeComponent();
        }

        string connection = "Data Source=DESKTOP-E65NGMS;Initial Catalog=HotelManagementSystem;Integrated Security=True;Trust Server Certificate=True";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgvGuests(string searchTerm, DataGridView dataGridView, string query)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection (connection))
            {
                conn.Open();

                
            }

        }

       

        private void LoadGuests()
        {
            string query = " ";

            try
            {
               
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    query = "select * from Guests";

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    DgvGuests.DataSource = dataTable;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            using (SqlConnection conn = new SqlConnection(connection))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                DgvGuests.DataSource = dataTable;
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
            tbPgAddGuest.Show();
        }

        private void BtnUpdatePage_Click(object sender, EventArgs e)
        {
            tbPgUpdateGuest.Show();
        }

        private void BtnDeleteGuest_Click(object sender, EventArgs e)
        {
            tbPageDeleteGuest.Show();
        }

        private void BtnReset_Delet_Click(object sender, EventArgs e)
        {
            txtFName_Delete.Clear();
           
        }

        private void BtnAddGuest_Click(object sender, EventArgs e)
        {
            string name = TxtFName_Add.Text;
            string surname = TxtLName_Add.Text;
            string contactNo = TxtContactNo_Add.Text;
            string email = TxtEmail_Add.Text;

            string query = "INSERT INTO Guest (Guest_FName, Guest_LName, Guest_ContactNo, Guest_Email) VALUES (@name, @surname, @contactNo, @email)";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@surname", surname);
                    command.Parameters.AddWithValue("@contactNo", contactNo);
                    command.Parameters.AddWithValue(@"email", email);   
                   
                    command.ExecuteNonQuery();
                    MessageBox.Show("Guest has been added");
                    LoadGuests();
                }
            }



        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //deleting of guest 

            string query = "DELETE FROM Guest WHERE Guest_FName = @name";
            string name = txtFName_Delete.Text;

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                using (SqlCommand comm = new SqlCommand(query, conn))

                    comm.Parameters.AddWithValue("@name", name);

                DialogResult dialogResult = MessageBox.Show("Would you liketo delete this guest:", "Delete Guest Confrimation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(dialogResult == DialogResult.Yes)
                {
                    /*int rowsAffected = comm.ExecuteNonQuery();
                     * if (rowsAffected > 0 ){
                     * comm.ExecuteNonQuery();
                     * MessageBox.Show("Guest has been successfully deleted");
                     * }
                     * else {
                     * MessageBox.Show("No guest found with the provided name selected");
                     * }
                     * }
                     * LoadData();
                     */


                }
            }
        }

        private void RdnBtnAscDelete_CheckedChanged(object sender, EventArgs e)
        {
            if(RdnBtnAscDelete.Checked)
            {
                //DgvGuests = ("SELECT * FROM Guest WHERE surname LIKE '%" + txtFName_Delete + "%' ORDER BY name ASC");
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            string name = TxtFName_Update.Text;
            string lastname = TxtLName_Update.Text;
            string contact = TxtContactNo_Update.Text;
            string email = TxtBoxEmail_Update.Text;

            try
            {
                using (SqlConnection conn = new SqlConnection(connection)) 
                {
                    conn.Open();

                    string query = " ";
                    query = "update Guests set Guest_FName = @name, Guest_LName = @lastname, Guest_ContactNo = @contact, Guest_Email = @email where Guest_FName = @name";

                    using (SqlCommand command = new SqlCommand (query, conn))
                    {

                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@surname", lastname);
                        command.Parameters.AddWithValue("@contact", contact);
                        command.Parameters.AddWithValue(@"email", email);
                        

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Guest information has been successfully updated");
                            LoadGuests();
                        }
                        else
                        {
                            MessageBox.Show("No guest has been updated");
                        }

                    }
                
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void DgvGuests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
