using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalBookRegistration
{
    class Book
    {
        private string _ISBN;

        public Book(string isbn, string title, double price) 
        { 
            ISBN = isbn;
            Title = title;
            Price = price;
        }

        public string ISBN 
        { 
            get { return _ISBN; }
            set { _ISBN = value; } 
        }

        public double Price { get; set; }

        public string Title { get; set; }

        public override string ToString()
        {
            return ISBN + ", " + Title + ", " +  Price.ToString("C");
        }
    }
}
