using BookLibrary.ConsoleApp.Framework;
using BookLibrary.ConsoleApp.Models;

namespace BookLibrary.ConsoleApp.Views;

public class BookSingleView
{
    private Book _book;
    public BookSingleView(Book model) => _book = model;

    public void Render()
    {
        if (_book == null)
        {
            ViewHelp.WriteLine("No book found",ConsoleColor.Red);
        }

        ViewHelp.WriteLine("Book detail information:",ConsoleColor.Green);
        Console.WriteLine($"Book name:   {_book!.Name}");
        Console.WriteLine($"Book Rating: {_book!.Rating}");
        Console.WriteLine($"Is Reading:  {_book!.Reading}");
        Console.WriteLine($"File:        {_book!.File}");
        Console.WriteLine($"File Name:   {_book!.FileName}");
    }
}
