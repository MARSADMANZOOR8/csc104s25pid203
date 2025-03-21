using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midProject.bl
{
    internal class ProjectsBL
    {
        public string title;
        public string description;

        public ProjectsBL(string title, string description)
        {
            this.title = title;
            this.description = description;
        }
    }
}
