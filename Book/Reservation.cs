using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class Reservation
    {
        public int id { get; private set; }
        public DateTime from { get; private set; }
        public DateTime to { get; private set; }
        private List<Book> books = new List<Book>();
        public Employee expedit { get; private set; }
        public Member member { get; private set; }

        internal Reservation(Employee emp, Member m, List<Book> b)
        {
            id = new Random().Next(100, 1000);
            from = DateTime.Now;
            to = from.AddDays(14);
            expedit = emp;
            member = m;
            foreach (var item in b)
            {
                 books.Add(item);
                 item.changeStatus();
            }

                    // member.addReservation(this);

        }
        internal Invoice Return()
        {
            foreach (var item in books)
            {
                item.changeStatus();
            }
            return new Invoice(member,this,from);
        }
    }
}
