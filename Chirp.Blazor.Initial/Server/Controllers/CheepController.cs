using Microsoft.AspNetCore.Mvc;
using Chirp.Blazor.Initial.Shared;

namespace Chirp.Blazor.Initial.Server.Controllers;

[ApiController]
[Route("/cheeps")]
public class CheepController : ControllerBase
{
    private readonly ICheepRepository _cheepRepository;

    public CheepController(ICheepRepository cheepRepository) {
        _cheepRepository = cheepRepository;
    }

    [HttpGet]
    public IEnumerable<Cheep> GetCheeps()
    {
        return _cheepRepository.Read().ToArray();
    }
    
    [HttpGet("{userName}")]
    public IEnumerable<Cheep> GetCheepsForAuthor(string userName)
    {
        return _cheepRepository.ReadByUserName(userName).ToArray();
    }
}