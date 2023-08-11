namespace Chirp.Blazor.Initial.Shared;

public interface ICheepRepository
{
    public IEnumerable<Cheep> Read();
    public IEnumerable<Cheep> ReadByUserName(string userName);
}
