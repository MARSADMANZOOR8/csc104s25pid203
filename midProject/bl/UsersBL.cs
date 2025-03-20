using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midProject.bl
{
    internal class UsersBL
    {
        public string username;
        public string password;
        public string email;
        public string role;

        public UsersBL(string username, string password, string email, string role)
        {
            this.username = username;
            this.password = password;
            this.email = email;
            this.role = role;
        }

        public UsersBL(string username, string email, string role)
        {
            this.username = username;
            this.email = email;
            this.role = role;
        }
    }
}
