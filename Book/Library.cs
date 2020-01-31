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
        readonly BookRepository br = new BookRepository();
        readonly EmployeeRepository er = new EmployeeRepository();
        // readonly InvoiceRepository ir = new InvoiceRepository();
        readonly MemberRepository mr = new MemberRepository();
        readonly ReservationRepository rr = new ReservationRepository();

        public void logIn(int id, string password)
        {
            if (er.getEmployeeById(id).checkPasswork(password))
            {
                loggedin = er.getEmployeeById(id);
                Console.WriteLine($"{loggedin.name} is logged in");
            }
            else
            {
                throw new InvalidOperationException("not logged in");
            }
        }
        public List<Book> getAvailableBook()
        {
            List<Book> availableBooks = br.GetlistOfAvailablebooks();
            return availableBooks;
        }

        public Reservation reserveBooks(int id, List<Book> list)
        {
            Member reservingMember = mr.getMemberById(id);
            if (reservingMember != null)
            {
                Reservation reservation = new Reservation(loggedin, reservingMember, list);
                rr.addReservation(reservation);
                reservingMember.addReservation(reservation);
                return reservation;
            }
            else { return null; }
        }

































        /// <summary>
        /// Denna metod använder vi endast för att få tillgång till testdata för att enklare testa våra funktioner
        /// den är inte den del av våran "riktiga" applikation.
        /// </summary>
        public void loadTestData()
        {
            Book b = new Book("0-3892-8755-5", "The Son of the Titan");
            Book b1 = new Book("0-9325-5864-X", "Devil's Vow");
            Book b2 = new Book("0-8280-8369-X", "Angel of Dragons");
            Book b3 = new Book("0-3689-3788-7", "The Blighted Temple");
            br.addBook(b);
            br.addBook(b1);
            br.addBook(b2);
            br.addBook(b3);

            Member mem = new Member(1, "Lois Haas", 07355521, "Lois.Haas@student.hb.se");
            Member mem1 = new Member(2, "Iona Moran", 07055552, "Iona.Moran@student.hb.se");
            Member mem2 = new Member(3, "Sophia Riggs", 07555531, "Sophia.Riggs@student.hb.se");
            Member mem3 = new Member(4, "Betty Alexander", 07655514, "Betty.Alexander@student.hb.se");
            mr.addMember(mem);
            mr.addMember(mem1);
            mr.addMember(mem2);
            mr.addMember(mem3);

            Employee emp = new Employee(1, "Edgar Park", "password", "Expedit");
            Employee emp1 = new Employee(2, "Margaret Newman", "12345", "Chef");
            Employee emp2 = new Employee(3, "Edith Morrison", "zinch", "Expedit");
            Employee emp3 = new Employee(4, "Hugh Saunders", "test", "Chef");
            er.addEmployee(emp);
            er.addEmployee(emp1);
            er.addEmployee(emp2);
            er.addEmployee(emp3);
        }




    }
}
