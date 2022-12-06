using Bacchus.Business;
using Bacchus.Common.Resources;
using Microsoft.AspNetCore.Mvc;

namespace Bacchus.API.Controllers;

[Produces("application/json")]
[Route("api/wines")]
public class WineController : Controller
{
    private readonly IService<WineResource> _wineService;

    public WineController(IService<WineResource> wineService)
    {
        _wineService = wineService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetItemById(int id)
    {
        WineResource wineResource = await _wineService.GetItemById(id);

        if (wineResource != null)
        {
            return Ok(wineResource);
        }

        return NotFound();
    }
}
