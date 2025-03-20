using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midProject.bl
{
    internal class FacultyBL
    {
        public string name { get; set; }
        public string email { get; set; }
        public string password;
        public string contact { get; set; }
        public string designation { get; set; }
        public string research_area { get; set; }
        public int teaching_hours { get; set; }

        public FacultyBL(string name, string email, string contact, string designation, string research_area, int teaching_hours)
        {
            this.name = name;
            this.email = email;
            this.contact = contact;
            this.designation = designation;
            this.research_area = research_area;
            this.teaching_hours = teaching_hours;
        }

        public FacultyBL(string name, string email, string password, string contact, string designation, string research_area, int teaching_hours)
        {
            this.name = name;
            this.email = email;
            this.contact = contact;
            this.password = password;
            this.designation = designation;
            this.research_area = research_area;
            this.teaching_hours = teaching_hours;
        }
    }
}
