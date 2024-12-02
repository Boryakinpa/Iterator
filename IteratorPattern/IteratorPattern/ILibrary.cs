using System.Collections;
namespace IteratorPattern
{

    public interface ILibrary
    {
        public void Add(Book book);
        public IEnumerator GetEnumerator();
    }
}