using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Member
    {
        MemberRepository mr = new MemberRepository();
        internal int Id { get; set; }
        public string Name { get; set; }
        private string PhoneNumber { get; set; }
        private string Email { get; set; }
        // internal Reservation CurrentReservation { get; set; }
        private List<Invoice> invoices = new List<Invoice>();
        private List<Reservation> reservations = new List<Reservation>();
        internal Member(int id, string name, string phoneNumber, string email)
        {
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;

        }
        public void AddReservation(Reservation res)
        {
            reservations.Add(res);
        }
        public void AddInvoice(Invoice invoice)
        {
            invoices.Add(invoice);          
        }

    }

}
