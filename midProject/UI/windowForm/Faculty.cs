using midProject.UI.userForm.Faculty;
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
    public partial class Faculty : Form
    {
        public Faculty()
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

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            ViewCources course = new ViewCources();
            AddPanel(course);
        }

        private void SubBtn_Click(object sender, EventArgs e)
        {
            ResourceReq resourceReq = new ResourceReq();
            AddPanel(resourceReq);
        }

        private void TrkBtn_Click(object sender, EventArgs e)
        {
            TrackReq req = new TrackReq();
            AddPanel(req);
        }
    }
}
