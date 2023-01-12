using BookLibrary.ConsoleApp.Models;

namespace BookLibrary.ConsoleApp.DataServices;

public class SimpleDataAccess
{
    public List<Book?> Books { get; set; }

    public void Load()
    {
        Books = new List<Book?>
        {
            new Book { Id = 1, Name = "New Book 1" },
            new Book { Id = 2, Name = "New Book 2" },
            new Book { Id = 3, Name = "New Book 3" },
            new Book { Id = 4, Name = "New Book 4" },
            new Book { Id = 5, Name = "New Book 5" }
        };
    }
    public void SaveChanges(){}
}