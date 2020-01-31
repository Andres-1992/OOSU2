using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{

   public class Book
    {
        private string ISBN { get; set; }
        public string title { get; set; }
        public bool isAvailable { get; set; }
        
        internal Book(string isbn,string title)
        {
            ISBN = isbn;
            this.title = title;
            isAvailable = true;

        } 
        public void changeStatus()
        {
            this.isAvailable = !isAvailable;
        }
           
    }
}
