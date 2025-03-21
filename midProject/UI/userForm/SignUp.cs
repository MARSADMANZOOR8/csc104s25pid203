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
using System.Security.Cryptography;
using midProject.bl;
using midProject.dl;

namespace midProject.UI.userForm
{
    public partial class SignUp : UserControl
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string pass = txtpass.Text;
            string email = txtemail.Text;
            string role = comboBox1.Text;

            UsersBL user = new UsersBL(name, pass, email, role);

            try
            {
                UsersDL.AddUser(user);
                int result = UsersDL.InsertUserData(user);
                if (result == 0)
                {
                    MessageBox.Show("Sign-up successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else if (result == 1)
                {
                    MessageBox.Show("Role not found in lookup table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                else if (result == 2)
                {
                    MessageBox.Show("Failed to sign up. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
