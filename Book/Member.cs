using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class Member
    {
        internal int id { get; set; }
        public string name { get; set; }
        private int phonenumber { get; set; }
        public string email { get; set; }
        public List<Reservation> reservations = new List<Reservation>();
        internal Member(int id, string name, int phonenumber, string email)
        {
            this.id = id;
            this.name = name;
            this.phonenumber = phonenumber;
            this.email = email;

        }
        public void addReservation(Reservation res)
        {
            reservations.Add(res);
        }
    }

}
