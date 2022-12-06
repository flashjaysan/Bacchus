using Bacchus.Business;
using Bacchus.Common.Resources;
using Microsoft.AspNetCore.Mvc;

namespace Bacchus.API.Controllers;

[Produces("application/json")]
[Route("api/winefamilies")]
public class WineFamilyController : Controller
{
    private readonly IService<WineFamilyResource> _wineFamilyService;

    public WineFamilyController(IService<WineFamilyResource> wineFamilyService)
    {
        _wineFamilyService = wineFamilyService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetItemById(int id)
    {
        WineFamilyResource wineFamilyResource = await _wineFamilyService.GetItemById(id);

        if (wineFamilyResource != null)
        {
            return Ok(wineFamilyResource);
        }

        return NotFound();
    }
}
