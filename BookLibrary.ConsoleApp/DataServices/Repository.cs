using BookLibrary.ConsoleApp.Models;

namespace BookLibrary.ConsoleApp.DataServices;

public class Repository
{
    protected readonly SimpleDataAccess _context;

    public Repository(SimpleDataAccess context)
    {
        _context = context;
        _context.Load();
    }

    public void SaveChanges() => _context.SaveChanges();
    public List<Book?> Books => _context.Books;
    public Book?[] Select() => _context.Books.ToArray();

    public Book? Select(int id)
    {
        foreach (var book in _context.Books)
        {
            if (book!.Id == id) return book;
        }
        return null;
    }

    public Book[] Select(string key)
    {
        var temp = new List<Book>();
        foreach (var book in _context.Books)
        { 
            if(book!.Name!.ToLower().Contains(key.ToLower())) temp.Add(book);
        }
        return temp.ToArray();
    }

    public void Insert(Book book)
    {
        var lastIndex = _context.Books.Count - 1;
        var id = lastIndex < 1 ? 1 : lastIndex;
        book.Id = id;
        _context.Books.Add(book);
    }

    public bool Delete(int id)
    {
        var b = Select(id);
        if (b == null) return false;
        _context.Books.Remove(b);
        return true;
    }

    public bool Update(int id, Book book)
    {
        var b = Select(id);
        if (b == null) return false;
        b.Name = book.Name;
        b.Rating = book.Rating;
        b.Reading = book.Reading;
        b.File = book.File;
        return true;
    }
}