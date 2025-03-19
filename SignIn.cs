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

namespace ProjectB.LoginF
{
    public partial class SignIn: Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIncs_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string connectionString = "server=127.0.0.1;port=3306;database=marsad;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT PasswordHash, Role FROM Users WHERE Username = @Username";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            string storedHash = reader["PasswordHash"].ToString();
                            string userRole = reader["Role"].ToString();

                            if (1==1
                                //BCrypt.Net.BCrypt.Verify(password, storedHash)
                                )
                            {
                                MessageBox.Show($"Login Successful! Role: {userRole}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Redirect based on role
                                if (userRole == "Admin")
                                {
                                    //new DepartmentHead().Show();
                                }
                                else if (userRole == "Faculty")
                                {
                                    //new FacultyMembers().Show();
                                }
                                else
                                {
                                    //new AdministrativeStaff().Show();
                                }

                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignUp().Show();
        }
    }
}
