using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{

    class BookRepository
    {
        List<Book> books = new List<Book>();

        public List<Book> GetlistOfAvailablebooks()
        {

            var result = books.Where(x => x.IsAvailable).ToList();


            return result;


        }

       public void AddBook(Book b)
        {
            books.Add(b);
        }
    }
}
