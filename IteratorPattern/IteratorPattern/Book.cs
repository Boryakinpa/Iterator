using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class Book
    {
        string Title { get; set; }
        string Author { get; set; }
        string Year { get; set; }
        public Book(string title, string author, string year)
        {
            Title = title;
            Author = author;
            Year = year;
        }
        public override string ToString()
        {
            return $"Название: {Title}\nАвтор: {Author}\nГод: {Year}";
        }
    }
}
