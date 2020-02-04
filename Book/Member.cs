using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Member
    {
       
        internal int Id { get; set; }
        public string Name { get; set; }
        private string PhoneNumber { get; set; }
        private string Email { get; set; }
        internal Member(int id, string name, string phoneNumber, string email)
        {
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;

        }
    }

}
