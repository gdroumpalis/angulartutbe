using Microsoft.AspNetCore.Mvc;

namespace angulartutbe.Controllers;

[ApiController]
[Route("[controller]")]
public class NavigationMenuController : ControllerBase
{
    private readonly ILogger<NavigationMenuController> _logger;

    public NavigationMenuController(ILogger<NavigationMenuController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetNavigationMenuEntries")]
    public IEnumerable<NavigationMenuEntry> Get()
    {
        return Enumerable.Empty<NavigationMenuEntry>();
    }
}