using midProject.UI.userForm.Adm;
using midProject.UI.userForm.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midProject.UI.windowForm
{
    public partial class Admin : Form
    {
        bool flag = true;
        public Admin()
        {
            InitializeComponent();
        }

        private void AddPanel(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UptBtn_Click(object sender, EventArgs e)
        {
                ManageFaculty manage = new ManageFaculty();
                AddPanel(manage);

        }

        private void MngBtn_Click(object sender, EventArgs e)
        {
            ManageCourses manage = new ManageCourses();
            AddPanel(manage);
        }

        private void ReqBtn_Click(object sender, EventArgs e)
        {
            FacultyRequests facultyRequests = new FacultyRequests();
            AddPanel(facultyRequests);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageCourses manage = new ManageCourses();
            AddPanel(manage);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
