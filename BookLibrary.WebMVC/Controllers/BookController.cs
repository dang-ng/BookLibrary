using BookLibrary.WebMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.WebMVC.Controllers;

public class BookController : Controller
{
    private readonly Service _service;

    public BookController(Service service)
    {
        _service = service;
    }
    // GET
    public IActionResult Index()
    {
        return View(_service.Get());
    }
}