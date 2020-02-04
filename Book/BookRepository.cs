using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{

    class BookRepository
    {
       private List<Book> books = new List<Book>();

        internal List<Book> GetlistOfAvailablebooks()
        {

            var result = books.Where(x => x.IsAvailable).ToList();


            return result;


        }

       internal void AddBook(Book b)
        {
            books.Add(b);
        }
        internal void LoadBooks()
        {
            Book b = new Book("0-3892-8755-5", "The Son of the Titan");
            Book b1 = new Book("0-9325-5864-X", "Devil's Vow");
            Book b2 = new Book("0-8280-8369-X", "Angel of Dragons");
            Book b3 = new Book("0-3689-3788-7", "The Blighted Temple");
            AddBook(b);
            AddBook(b1);
            AddBook(b2);
            AddBook(b3);
        }
    }
}
