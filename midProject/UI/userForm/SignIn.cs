using midProject.dl;
using midProject.UI.windowForm;  // Ensure correct reference to the Admin form
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace midProject.UI.userForm
{
    public partial class SignIn : UserControl
    {
        public static int GlobalUserID { get; set; }
        public SignIn()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text.Trim();
            string pass = txtpass.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please enter both email and password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DataBaseHelper.GetConnection())
                {
                    conn.Open();
                    string hashedPassword = UsersDL.HashPassword(pass);
                    string query = "SELECT username, role_id, user_id FROM [users] WHERE email = @Email AND password_hash = @Password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", hashedPassword);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            string username = reader["username"].ToString();
                            int role_id = Convert.ToInt32(reader["role_id"]);
                            GlobalUserID = Convert.ToInt32(reader["user_id"]);

                            MessageBox.Show($"Welcome, {username}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (role_id == 1)
                            {
                                midProject.UI.windowForm.Admin admin = new midProject.UI.windowForm.Admin();  // Ensure correct reference
                                admin.ShowDialog();
                            }
                            else if (role_id == 2)
                            {
                                midProject.UI.windowForm.Faculty f = new midProject.UI.windowForm.Faculty();  // Ensure correct reference
                                f.ShowDialog();
                            }
                            else if (role_id == 3)
                            {
                                midProject.UI.windowForm.DeptHead Head = new midProject.UI.windowForm.DeptHead();  // Ensure correct reference
                                Head.ShowDialog();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
