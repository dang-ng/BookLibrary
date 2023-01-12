using BookLibrary.ConsoleApp.Framework;

namespace BookLibrary.ConsoleApp.Views;
using Framework;
public class BookCreateView
{
    public BookCreateView()
    {
    }

    public void Render()
    {
        ViewHelp.WriteLine("Create New Book", ConsoleColor.Green);
        var name = ViewHelp.InputString("Name");
        var rating = ViewHelp.InputInt("Rate");
        var reading = ViewHelp.InputBool("Rating");;
        var file = ViewHelp.InputString("File");
    }
}