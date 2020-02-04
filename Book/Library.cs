using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Library
    {
        private Employee loggedin;
        private InvoiceRepository ir = new InvoiceRepository();
        private BookRepository br = new BookRepository();
        private EmployeeRepository er = new EmployeeRepository();
        private MemberRepository mr = new MemberRepository();
        private ReservationRepository rr = new ReservationRepository();

        public bool LogIn(int id, string password)
        {
            Employee e = er.GetEmployeeById(id);

            if (e.CheckPassword(password))
            {
                loggedin = e;
                return true;
            }
            else
            {
                return false;
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
            br.LoadBooks();

            mr.LoadMembers();

            er.LoadEmployees();
        }




    }
}
