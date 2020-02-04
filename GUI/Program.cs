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
            l.LoadTestdata();

            Console.Write("Enter your Employee number: ");
            int id = TryInt();
            Console.Write("Enter your password: ");
            string password = GetHiddenConsoleInput();
            Console.WriteLine();
            ;
            Console.Clear();

            if (l.LogIn(id, password))
            {



                bool fortsätt = true;
                while (fortsätt)
                {
                    Console.WriteLine("[1] Make reservation");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("[2] Return books");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("[3] Show available books");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("[4] Exit");
                    Console.WriteLine("----------------------");
                    Console.Write("Enter Menu selection: ");

                    int menyVal = TryInt();

                    switch (menyVal)
                    {
                        case 1:
                            Console.Clear();
                            foreach (var item in l.GetAvailableBook())
                            {
                                Console.WriteLine("Titel:  {0}", item.Title);
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

                                foreach (var item in l.GetAvailableBook())
                                {
                                    if (item.Title.ToLower() == booktitle)
                                    {
                                        chosenBooks.Add(item);
                                    }
                                }
                                Console.Write("Do you want to continue Y/N: ");
                                answer = Console.ReadLine().ToLower();
                                Console.WriteLine();
                            }
                            Reservation reservation = l.ReserveBooks(memberid, chosenBooks);
                            if (reservation == null)
                            {
                                Console.WriteLine("Your reservation couldn't be added");
                            }
                            else
                            {
                                Console.WriteLine("Reservation number is: {0}", reservation.Id);
                            }
                            Console.WriteLine("yani tryck nåt för o gå vidare, släppt det bara");
                            Console.ReadLine();
                            break;
                        case 2:
                            Console.Clear();
                            int reservationnumber;
                            Console.Write("Enter reservation number: ");
                            reservationnumber = TryInt();
                            Invoice invoice = l.ReturnBooks(reservationnumber);
                            if (invoice != null)
                            {
                                Console.WriteLine("The total amount for {0} is {1:c}", invoice.Member.Name, invoice.TotalPrice);
                            }
                            else
                            {
                                Console.WriteLine("The reservation number {0} does not exist", reservationnumber);
                            }
                            Console.ReadLine();
                            break;
                        case 3:
                            Console.Clear();
                            foreach (var item in l.GetAvailableBook())
                            {
                                Console.WriteLine("Titel:  {0}", item.Title);
                            }
                            Console.ReadLine();
                            break;

                        case 4:
                            fortsätt = false;
                            break;
                    }


                }

            }
            else
            {
                Console.WriteLine("wrong password");
                Console.ReadLine();
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
