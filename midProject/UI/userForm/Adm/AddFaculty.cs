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

namespace midProject.UI.userForm.Admin
{
    public partial class AddFaculty : UserControl
    {
        public AddFaculty()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            string password = PassTxt.Text;
            string email = EmTxt.Text;
            string contact = ConTxt.Text;
            string research_area = ResTxt.Text;
            int TotalHours = Convert.ToInt32(HrsTxt.Text);
            string designation = DesignationTxt.Text;

            FacultyBL faculty = new FacultyBL(name, email, password, contact, designation, research_area, TotalHours);
            FacultyDL.AddFaculty(faculty);
            int result = FacultyDL.InsertIntoFaculty(faculty);
            if (result == 0)
            {
                MessageBox.Show("Added Successfully");
            }

        }
    }
}
