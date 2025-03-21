using midProject.bl;
using midProject.dl;
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
    public partial class CreateProjects : UserControl
    {
        public CreateProjects()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string title = NameTxt.Text;
            string desc = DesTxt.Text;
            if (title != string.Empty && desc != string.Empty)
            {
                ProjectsBL project = new ProjectsBL(title, desc);
                int result = ProjectsDL.InsertProject(project);
                if (result == 1)
                {
                    MessageBox.Show("Project Created Successfully");
                }
                else
                {
                    MessageBox.Show("Unable to create project");
                }
            }
        }
    }
}
