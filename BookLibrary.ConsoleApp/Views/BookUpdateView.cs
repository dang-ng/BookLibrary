using BookLibrary.ConsoleApp.Framework;
using BookLibrary.ConsoleApp.Models;

namespace BookLibrary.ConsoleApp.Views;

public class BookUpdateView
{
    private Book _book;
    public BookUpdateView(Book model) => _book = model;

    public void Render()
    {
        ViewHelp.WriteLine("Update Book Information:",ConsoleColor.Green);
        var name = ViewHelp.InputString("Name", _book.Name);
    }
    
}