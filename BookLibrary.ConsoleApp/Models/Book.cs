namespace BookLibrary.ConsoleApp.Models;

public class Book
{
    private int _id = 1;
    private string? _name = "Không tên";
    private int _rating = 1;
    private string _file;

    public int Id
    {
        get => _id;
        set
        {
            if (value >= 1) _id = value;
        }
    }

    public string? Name
    {
        get => _name;
        set
        {
            if (!string.IsNullOrEmpty(value)) _name = value;
        }
    }

    public int Rating
    {
        get => _rating;
        set
        {
            if (value >= 1 && value <= 5) _rating = value;
        }
    }

    public bool Reading { get; set; } = true;

    public string File
    {
        get => _file;
        set
        {
            if(System.IO.File.Exists(value)) _file = value;
        }
    }

    public string FileName
    {
        get => System.IO.Path.GetFileName(_file);
    }
}
