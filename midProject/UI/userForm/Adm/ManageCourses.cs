using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midProject.UI.userForm.Adm
{
    public partial class ManageCourses : UserControl
    {
        public ManageCourses()
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


        private void AddCourse_Click(object sender, EventArgs e)
        {
            CreateCourse course = new CreateCourse();
            AddPanel(course);
        }

        private void AlcBtn_Click(object sender, EventArgs e)
        {
            AllocateCourse allocate = new AllocateCourse();
            AddPanel(allocate);

        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            ViewFacultyCourses course = new ViewFacultyCourses();
            AddPanel(course);
        }
    }
}
