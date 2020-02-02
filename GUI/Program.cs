using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;


namespace GUI
{
    public class Program
    {

        static void Main(string[] args)
        {

            Library l = new Library();
            l.loadTestData();

            Console.Write("Enter your Employee number: ");
            int id = TryInt();
            Console.Write("Enter your password: ");
            string password = GetHiddenConsoleInput();
            Console.WriteLine();
            l.logIn(id, password);
            Console.Clear();
            bool fortsätt = true;
            while (fortsätt)
            {
                Console.WriteLine("[1] Boka");
                Console.WriteLine("----------------------");
                Console.WriteLine("[2] Lämna tillbaka");
                Console.WriteLine("----------------------");
                Console.WriteLine("[3] avsluta");
                Console.WriteLine("----------------------");
                Console.Write("Ange menyval: ");

                int menyVal = int.Parse(Console.ReadLine());

                switch (menyVal)
                {
                    case 1:
                        Console.Clear();
                        foreach (var item in l.getAvailableBook())
                        {
                            Console.WriteLine("Titel:  {0}", item.title);
                        }
                        Console.WriteLine();
                        Console.Write("Enter Member ID: ");
                        int memberid = TryInt();
                        List<Book> chosenBooks = new List<Book>();
                        string answer = "y";
                        while (answer == "y")
                        {
                            Console.Write("Enter book title: ");
                            string booktitle = Console.ReadLine().ToLower();

                            foreach (var item in l.getAvailableBook())
                            {
                                if (item.title.ToLower() == booktitle)
                                {
                                    chosenBooks.Add(item);
                                }
                            }
                            Console.Write("Do you want to continue Y/N: ");
                            answer = Console.ReadLine().ToLower();
                            Console.WriteLine();


                        }
                        Reservation reservation = l.reserveBooks(memberid, chosenBooks);
                        Console.WriteLine("Reservation number is: {0}", reservation.id);
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        int reservationnumber;
                        Console.Write("Enter reservation number: ");
                        reservationnumber = TryInt();
                        Invoice invoice = l.returnbooks(reservationnumber);
                        Console.WriteLine("The total amount for {0} is {1:c}", invoice.member.name, invoice.totalAmount);
                        Console.ReadLine();
                        break;
                    case 3:
                        fortsätt = false;
                        break;
                }
            }
        }
        private static string GetHiddenConsoleInput()
        {
            StringBuilder input = new StringBuilder();
            while (true)
            {
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter) break;
                if (key.Key == ConsoleKey.Backspace && input.Length > 0) input.Remove(input.Length - 1, 1);
                else if (key.Key != ConsoleKey.Backspace) input.Append(key.KeyChar);
            }
            return input.ToString();
        }
        public static int TryInt()
        {

            int d;

            while (!int.TryParse(Console.ReadLine(), out d))
            {
                Console.Write("Måste vara ett numeriskt värde\nFörsök igen: ");


            }
            return d;
        }
    }
}
