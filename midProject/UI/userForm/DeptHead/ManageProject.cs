using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midProject.UI.userForm.DeptHead
{
    public partial class ManageProject : UserControl
    {
        public ManageProject()
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

        private void AddProject_Click(object sender, EventArgs e)
        {
            CreateProjects createProjects = new CreateProjects();
            AddPanel(createProjects);
        }

        private void AlcBtn_Click(object sender, EventArgs e)
        {
            AssignProjects assignProjects = new AssignProjects();
            AddPanel(assignProjects);
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            ViewProjects viewProjects = new ViewProjects();
            AddPanel(viewProjects);
        }
    }
}
