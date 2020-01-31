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
        static void Main(string[] args)
        {
            
            Library l = new Library();
            l.loadTestData();

            int id = int.Parse(Console.ReadLine());
            string password = GetHiddenConsoleInput();
            l.logIn(id, password);
            Console.ReadLine();

            foreach (var item in l.getAvailableBook())
            {
                Console.WriteLine("Titel:  " + item.title);
            }

            Console.WriteLine("enter member id");
            int memberid = int.Parse(Console.ReadLine());
            Console.WriteLine("enter book title");
            string booktitle = Console.ReadLine().ToLower();
            List<Book> chosenBooks = new List<Book>();
            foreach (var item in l.getAvailableBook())
            {
                if (item.title.ToLower() == booktitle)
                {
                    chosenBooks.Add(item);
                }
            }
            _ = l.reserveBooks(memberid, chosenBooks);
            foreach (var item in l.getAvailableBook())
            {
                Console.WriteLine("Titel:  " + item.title);
            }
            Console.ReadLine();
        }
    }
}
