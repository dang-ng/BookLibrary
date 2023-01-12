namespace BookLibrary.ConsoleApp.Framework;

public static class ViewHelp
{
    public static void WriteLine(string message, ConsoleColor color, bool resetColor = true)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        if(resetColor)Console.ResetColor();
    }
    public static void Write(string message, ConsoleColor color, bool resetColor = true)
    {
        Console.ForegroundColor = color;
        Console.Write(message);
        if(resetColor)Console.ResetColor();
    }
    
    public static bool InputBool(string label, ConsoleColor labelColor = ConsoleColor.Magenta, ConsoleColor resultColor = ConsoleColor.White)
    {
        while (true)
        {
            Write($"{label} (Y/N): ", labelColor);
            var key = Console.ReadKey();
            Console.WriteLine();
            if (key.KeyChar == 'Y' || key.KeyChar == 'y') return true;
            if (key.KeyChar == 'N' || key.KeyChar == 'n') return false;
        }
    }
    public static string? InputString(string label, ConsoleColor labelColor = ConsoleColor.Magenta, ConsoleColor resultColor = ConsoleColor.White)
    {
        Write($"{label}: ",labelColor,false);
        Console.ForegroundColor = resultColor;
        string? value = Console.ReadLine();
        Console.ResetColor();
        return value;
    }
    public static string? InputString(string label, string oldValue, ConsoleColor labelColor = ConsoleColor.Magenta, ConsoleColor resultColor = ConsoleColor.White)
    {
        Write($"{label}: ",labelColor);
        WriteLine(oldValue,ConsoleColor.Yellow);
        Write("New value: ", ConsoleColor.Green);
        Console.ForegroundColor = resultColor;
        string? value = Console.ReadLine();
        Console.ResetColor();
        return string.IsNullOrEmpty(value?.Trim()) ? oldValue : value;
    }

    public static int InputInt(string label, ConsoleColor labelColor = ConsoleColor.Magenta,
        ConsoleColor resultColor = ConsoleColor.White)
    {
        while (true)
        {
            var @string = InputString(label, labelColor, resultColor);
            var result = int.TryParse(@string, out int i);
            if (result) return i;
        }
    }
}