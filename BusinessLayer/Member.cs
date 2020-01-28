using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class Member
    {
        private int id { get; set; }
        private string namn { get; set; }
        private int telefonnummer { get; set; }
        private string email { get; set; }
        private List<Reservation> reservations { get; set; }
    }

}
