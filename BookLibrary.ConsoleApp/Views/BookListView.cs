using BookLibrary.ConsoleApp.Framework;
using BookLibrary.ConsoleApp.Models;

namespace BookLibrary.ConsoleApp.Views;

public class BookListView
{
    protected Book[] _books;
    public BookListView(Book[] books) => _books = books;

    public void Render()
    {
        if (_books.Length == 0)
        {
            ViewHelp.WriteLine("No book found",ConsoleColor.Red);
            return;
        } 
        ViewHelp.WriteLine("The book list:", ConsoleColor.Green);
        foreach (var book in _books)
        {
            ViewHelp.Write($"[{book.Id}] ",ConsoleColor.Yellow);
            ViewHelp.WriteLine($"{book.Name}",book.Reading?ConsoleColor.Cyan:ConsoleColor.White);
        }
    }
}