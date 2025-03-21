using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midProject.bl
{
    internal class CourseBL
    {
        public string course_name;
        public string course_type;
        public int credit_hours;
        public int contact_hours;

        public CourseBL(string course_name, string course_type, int credit_hours, int contact_hours)
        {
            this.course_name = course_name;
            this.course_type = course_type;
            this.credit_hours = credit_hours;
            this.contact_hours = contact_hours;
        }
    }
}
