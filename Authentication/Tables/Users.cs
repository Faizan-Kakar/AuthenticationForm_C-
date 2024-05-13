using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Tables
{
    internal class Users
    {
        public int id { get; set;}
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String email { get; set; }
        public String password { get; set; }
        public String confirmPassword { get; set; }
    }
}
