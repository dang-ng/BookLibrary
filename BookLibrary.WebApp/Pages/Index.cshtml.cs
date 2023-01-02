using BookLibrary.WebApp.Interface;
using BookLibrary.WebApp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookLibrary.WebApp.Pages;

public class IndexModel : PageModel
{
    private readonly IRepository _repository;

    public IndexModel(IRepository repository) => this._repository = repository;

    public HashSet<Book> Books => _repository.Books;
    public int Count => _repository.Books.Count;
    public void OnGet()
    {
    }
}