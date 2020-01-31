using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Employee
    {
        internal int id { get; set; }
        public string name { get; set; }
        private string password { get; set; }
        public string role { get; set; }

        public bool  checkPasswork(string password)
        {
            if (this.password == password)
            {
                return true;
            }
            else return false;
        }
        internal Employee(int id, string name, string password, string role)
        {
            this.id = id;
            this.name = name;
            this.password = password;
            this.role = role;
        }

    }

}
