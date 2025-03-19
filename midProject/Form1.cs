using midProject.UI.userForm;
using System;
using System.Windows.Forms;

namespace midProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}