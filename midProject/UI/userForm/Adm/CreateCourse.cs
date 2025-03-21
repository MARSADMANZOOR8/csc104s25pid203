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

namespace midProject.UI.userForm.Adm
{
    public partial class CreateCourse : UserControl
    {
        public CreateCourse()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string name = NameTxt.Text;
            string type = TypeTxt.Text.Length > 10 ? TypeTxt.Text.Substring(0, 10) : TypeTxt.Text;

            if (string.IsNullOrWhiteSpace(type))
            {
                MessageBox.Show("Course Type cannot be empty!");
                return;
            }
            int credit_hours = Convert.ToInt32(HoursTxt.Text);
            int contact_hours = Convert.ToInt32(HrsTxt.Text);
            CourseBL course = new CourseBL(name, type, credit_hours, contact_hours);
            int result = CourseDL.InsertCourse(course);
            if(result == 1)
            {
                MessageBox.Show("Course Created Successfully");
            }
            else
            {
                MessageBox.Show("Unable to create course");
            }
        }
    }
}
