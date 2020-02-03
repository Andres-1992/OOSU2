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
        public string Title { get; set; }
        internal bool IsAvailable { get; set; }
        
        internal Book(string isbn,string title)
        {
            ISBN = isbn;
            Title = title;
            IsAvailable = true;

        } 
        internal void ChangeStatus()
        {
            this.IsAvailable = !IsAvailable;
        }
           
    }
}
