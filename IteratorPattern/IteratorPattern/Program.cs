using System.Collections;
using System.Linq;
using IteratorPattern;

public class Program
{
    private static void Main(string[] args)
    {
        Library library = new Library();
        library.Add(new Book("Море", "Егор", "2024"));
        library.Add(new Book("Пляж", "Егор", "2024г"));
        foreach(var book in library)
        {
            Console.WriteLine(book.ToString());
        }
    }
}

