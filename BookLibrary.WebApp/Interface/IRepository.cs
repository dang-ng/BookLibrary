using BookLibrary.WebApp.Model;

namespace BookLibrary.WebApp.Interface;

public interface IRepository
{
    public HashSet<Book> Books { get; set; }
    public Book? Get(int id);
}