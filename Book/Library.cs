using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Library
    {
        Employee loggedin;
        readonly  InvoiceRepository ir = new InvoiceRepository();
        readonly BookRepository br = new BookRepository();
        readonly EmployeeRepository er = new EmployeeRepository();
        readonly MemberRepository mr = new MemberRepository();
        readonly ReservationRepository rr = new ReservationRepository();

        public void LogIn(int id, string password)
        {
            if (er.GetEmployeeById(id).CheckPassword(password))
            {
                loggedin = er.GetEmployeeById(id);
            }
            else
            {
                throw new InvalidOperationException("not logged in");
            }
        }
        public List<Book> GetAvailableBook()
        {
            List<Book> availableBooks = br.GetlistOfAvailablebooks();
            return availableBooks;
        }

        public Reservation ReserveBooks(int id, List<Book> list)
        {
            Member reservingMember = mr.GetMemberById(id);
            if (reservingMember != null && list.Count>0)
            {
                Reservation reservation = new Reservation(loggedin, reservingMember, list);
                rr.AddReservation(reservation);
               // reservingMember.CurrentReservation = reservation;
                  reservingMember.AddReservation(reservation);
                return reservation;
            }
            else { return null; }
        }

        public Invoice ReturnBooks(int reservationNumber)
        {
            Reservation reservation =rr.GetReservationById(reservationNumber);
            if (loggedin != null && reservation != null)
            {
                Invoice invoice =reservation.Return();
                reservation.Member.AddInvoice(invoice);
                ir.AddInvoice(invoice);                
                return invoice;                
            }
            else { return null; }           
        }

        /// <summary>
        /// Denna metod använder vi endast för att få tillgång till testdata för att enklare testa våra funktioner
        /// den är inte den del av våran "riktiga" applikation.
        /// </summary>
        public void LoadTestdata()
        {
            Book b = new Book("0-3892-8755-5", "The Son of the Titan");
            Book b1 = new Book("0-9325-5864-X", "Devil's Vow");
            Book b2 = new Book("0-8280-8369-X", "Angel of Dragons");
            Book b3 = new Book("0-3689-3788-7", "The Blighted Temple");
            br.AddBook(b);
            br.AddBook(b1);
            br.AddBook(b2);
            br.AddBook(b3);

            Member mem = new Member(1, "Lois Haas", "07355521", "Lois.Haas@student.hb.se");
            Member mem1 = new Member(2, "Iona Moran", "07055552", "Iona.Moran@student.hb.se");
            Member mem2 = new Member(3, "Sophia Riggs", "07555531", "Sophia.Riggs@student.hb.se");
            Member mem3 = new Member(4, "Betty Alexander", "07655514", "Betty.Alexander@student.hb.se");
            mr.AddMember(mem);
            mr.AddMember(mem1);
            mr.AddMember(mem2);
            mr.AddMember(mem3);

            Employee emp = new Employee(1, "Edgar Park", "password", "Expedit");
            Employee emp1 = new Employee(2, "Margaret Newman", "12345", "Chef");
            Employee emp2 = new Employee(3, "Edith Morrison", "zinch", "Expedit");
            Employee emp3 = new Employee(4, "Hugh Saunders", "test", "Chef");
            er.AddEmployee(emp);
            er.AddEmployee(emp1);
            er.AddEmployee(emp2);
            er.AddEmployee(emp3);
        }




    }
}
