namespace BookLibrary.ConsoleApp.Framework;

public class Parameter
{
    private readonly Dictionary<string, string?> _pairs = new Dictionary<string, string?>();

    public string? this[string key]
    {
        get => _pairs.ContainsKey(key) ? _pairs[key] : null;
        set => _pairs[key] = value;
    }

    public bool ContainsKey(string key) => _pairs.ContainsKey(key);

    public Parameter(string parameter)
    {
        var pairs = parameter.Split(new[] { '&' }, StringSplitOptions.RemoveEmptyEntries);
        
    }
}