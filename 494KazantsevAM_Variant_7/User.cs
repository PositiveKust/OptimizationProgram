using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _494KazantsevAM_Variant_7
{
    public class User
    {
        public int id { get; set; }
        private string name, password;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public User() { }
        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
    }
}
