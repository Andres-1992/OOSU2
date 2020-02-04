using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class Reservation
    {
        public int Id { get; private set; }
        private DateTime From { get;  set; }
        internal DateTime To { get; private set; }
        private List<Book> books = new List<Book>();
        private Employee Expedit { get; set; }
        internal Member Member { get; set; }

        internal Reservation(Employee employee, Member member, List<Book> book)
        {
            Id = new Random().Next(100, 1000);
            From = DateTime.Now;
            To = From.AddDays(14);
            Expedit = employee;
            Member = member;
            foreach (var item  in book)
            {
                 books.Add(item);
                 item.ChangeStatus();
            }

        }
        internal Invoice Return()
        {
            foreach (var item in books)
            {
                item.ChangeStatus();
            }
            return new Invoice(Member,this,From);
        }
    }
}
