using IteratorPattern;
public interface ILibraryEnumerator
{
    object Current { get; }

    bool MoveNext();
    void Reset();
}