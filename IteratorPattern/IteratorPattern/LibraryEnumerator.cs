using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class LibraryEnumerator : IEnumerator, ILibraryEnumerator
    {
        Book[] _books;
        int position = -1;
        public LibraryEnumerator(Book[] books)
        {
            _books = books;
        }
        public object Current
        {
            get
            {
                if (position == -1 || position >= _books.Length)
                    throw new ArgumentException();
                return _books[position];
            }
        }

        public bool MoveNext()
        {
            if (position < _books.Length - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }

        public void Reset() => position = -1;
    }
}
