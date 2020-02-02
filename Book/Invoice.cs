using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class Invoice
    {
        internal Reservation reservation { get; set; }
        public Member member { get; set; }
        public double totalAmount { get; set; }
        private DateTime from { get; set; }
        private DateTime to { get; set; }

        internal Invoice(Member m, Reservation r, DateTime from )
        {
            member = m;
            reservation = r;
            this.from = from;
            to = DateTime.Now;
            if (to.Date > reservation.to.Date)
            {
                totalAmount = ((to.Date - reservation.to.Date).TotalDays) * 10;
            }            
            else
            {
                totalAmount = 0;
            }
        }
    }

}
