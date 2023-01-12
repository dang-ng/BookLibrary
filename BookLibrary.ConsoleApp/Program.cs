// See https://aka.ms/new-console-template for more information

using BookLibrary.ConsoleApp.Controllers;
using BookLibrary.ConsoleApp.DataServices;

SimpleDataAccess context = new SimpleDataAccess();
BookController controller = new BookController(context);
while (true)
{
    Console.Write("Request>> ");
    string? request = Console.ReadLine();
    switch (request.ToLower())
    {
        case "single": controller.Single(1);
            break;
        case "create": controller.Create();
            break;
        case "update": controller.Update(1);
            break;
        case "list": controller.List();
            break;
        default: Console.WriteLine("Unknown Command");
            break;
    }
}
