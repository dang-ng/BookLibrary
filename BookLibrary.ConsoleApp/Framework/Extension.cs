namespace BookLibrary.ConsoleApp.Framework;

public static class Extension
{
    public static int ToInt(this string value) => int.Parse(value);

    public static bool ToInt(this string value, out int i) => int.TryParse(value, out i);

    public static bool ToBool(this string value) => value.ToLower() == "y" || value.ToLower() == "true";

    public static string ToString(this bool value, string format)
    {
        if(format=="y/n") return value ? "Yes" : "No";
        if (format == "c/k") return value ? "Có" : "Không";
        return value ? "True" : "False";
    }
}