using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Employee
    {
        internal int Id { get; set; }
        private string Name { get; set; }
        private string Password {  get; }
        private string Role { get; set; }

        internal bool  CheckPassword(string password)
        {
            if (Password == password)
            {
                return true;
            }
            else return false;
        }
        internal Employee(int id, string name, string password, string role)
        {
            Id = id;
            Name = name;
            Password = password;
            Role = role;
        }
    }

}
