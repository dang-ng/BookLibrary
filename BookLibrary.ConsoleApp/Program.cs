// See https://aka.ms/new-console-template for more information

using BookLibrary.ConsoleApp.Controllers;
using BookLibrary.ConsoleApp.DataServices;
using BookLibrary.ConsoleApp.Framework;

public class Program
{
    public static void Main(string[] args)
    {
        
        SimpleDataAccess context = new SimpleDataAccess();
        BookController controller = new BookController(context);
        Router.Instance.Register("about",About);
        Router.Instance.Register("help",Help);
        while (true)
        {
            Console.Write("Request>> ");
            string? request = Console.ReadLine();
            Router.Instance.Forward(request);
            Console.WriteLine();
            // switch (request.ToLower())
            // {
            //     case "single": controller.Single(1);
            //         break;
            //     case "create": controller.Create();
            //         break;
            //     case "update": controller.Update(1);
            //         break;
            //     case "list": controller.List();
            //         break;
            //     default: Console.WriteLine("Unknown Command");
            //         break;
        }
    }
    private static void About(Parameter parameter)
    {
        ViewHelp.WriteLine("Book Manager version 1.0",ConsoleColor.Magenta);
        ViewHelp.WriteLine("By Nguyen Hai Dang",ConsoleColor.Blue);
    }

    private static void Help(Parameter parameter)
    {
        if (parameter == null)
        {
            ViewHelp.WriteLine("Supported Command",ConsoleColor.Green);
            ViewHelp.WriteLine(Router.Instance.GetRoutes(),ConsoleColor.Yellow);
            ViewHelp.WriteLine("type: help?cmd=<command> to get command detail",ConsoleColor.Cyan);
        }
        var command = parameter["cmd"].ToLower();
        ViewHelp.WriteLine(Router.Instance.GetHelp(command),ConsoleColor.Green);
    }

}


