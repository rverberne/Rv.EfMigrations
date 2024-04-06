using Microsoft.AspNetCore.Mvc;

namespace Rv.CatApi.Cats;

[ApiController]
[Route("api")]
public class CatsController : ControllerBase
{
    private readonly ILogger<CatsController> _logger;

    public CatsController(ILogger<CatsController> logger)
    {
        _logger = logger;
    }

    [HttpGet("cats/{catId}")]
    public Cat? GetById([FromRoute] string catId)
    {
        return new Cat { Name = "Felix" };
    }
}
