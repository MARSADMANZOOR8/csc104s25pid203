using midProject.UI.userForm;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace midProject
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load; // Attach Load event handler
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }

 


        private void AddPanel(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel6.Controls.Clear();
            panel6.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            SignUp signUpUserControl = new SignUp();
            AddPanel(signUpUserControl);
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            SignIn signUpUserControl = new SignIn();
            AddPanel(signUpUserControl);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            // Empty event handler
        }
    }
}
