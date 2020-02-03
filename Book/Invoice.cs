using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Invoice
    {
        internal int Id {get;set;}
        internal Reservation Reservation { get; set; }
        public Member Member { get; set; }
        public double TotalPrice { get; set; }
        private DateTime From { get; set; }
        private DateTime To { get; set; }

        internal Invoice(Member m, Reservation r, DateTime from )
        {
            Id = new Random().Next(800, 1000);
            Member = m;
            Reservation = r;
            this.From = from;
            To = DateTime.Now;
            if (To.Date > Reservation.To.Date)
            {
                TotalPrice = ((To.Date - Reservation.To.Date).TotalDays) * 10;
            }            
            else
            {
                TotalPrice = 0;
            }
        }
    }

}
