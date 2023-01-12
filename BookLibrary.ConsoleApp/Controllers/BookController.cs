using BookLibrary.ConsoleApp.DataServices;
using BookLibrary.ConsoleApp.Models;
using BookLibrary.ConsoleApp.Views;

namespace BookLibrary.ConsoleApp.Controllers;

public class BookController
{
    protected Repository Repository;
    public BookController(SimpleDataAccess context)
    {
        Repository = new Repository(context);
    }
    public void Single(int id)
    {
        var model = Repository.Select(id);
        BookSingleView view = new BookSingleView(model);
        view.Render();
    }

    public void Create()
    {
        BookCreateView view = new BookCreateView();
        view.Render();
    }

    public void Update(int id)
    {
        var model = Repository.Select(id);
        var view = new BookUpdateView(model);
        view.Render();
    }

    public void List()
    {
        var books = Repository.Select();
        var view = new BookListView(books);
        view.Render();
    }
}