using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class Library : IEnumerable, ILibrary
    {
        Book[] books = new Book[0] { };
        public void Add(Book book)
        {
            Book[] booksTemp = new Book[books.Length + 1];
            for (int i = 0; i < books.Length; i++)
            {
                booksTemp[i] = books[i];
            }
            for (int i = books.Length; i < booksTemp.Length; i++)
            {
                booksTemp[i] = book;
            }
            books = booksTemp;
        }

        public IEnumerator GetEnumerator() => new LibraryEnumerator(books);
    }
}
