using System.Globalization;

namespace Chirp.Blazor.Initial.Shared;

public class CheepRepository : ICheepRepository
{
    // These would normally be loaded from a database context for example
    private static readonly List<Cheep> _cheeps = new()
        {
            new Cheep("Helge", "Hello, BDSA students!", DateTime.ParseExact("08/01/23 14:16:48 +02:00", "MM/dd/yy H:mm:ss", CultureInfo.InvariantCulture)),
            new Cheep("Rasmus", "Hej, velkommen til kurset.", DateTime.ParseExact("08/01/23 15:08:28 +02:00", "MM/dd/yy H:mm:ss", CultureInfo.InvariantCulture)),
        };

    public IEnumerable<Cheep> Read()
    {
        return _cheeps;
    }

    public IEnumerable<Cheep> ReadByUserName(string userName)
    {
        return _cheeps.Where(c => c.Author == userName);
    }
}