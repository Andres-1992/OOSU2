using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class Reservation
    {
        private int id { get; set; }
        public DateTime from { get; set; }
        public DateTime to {get { return to; } set
            {
               to = from.AddDays(14);
            }
        }
        private List<Book> books { get; set; }
        private Employee expedit { get; set; }
        private Member member { get; set; }

    }
}
