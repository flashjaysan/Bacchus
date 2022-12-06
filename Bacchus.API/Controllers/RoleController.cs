using Bacchus.Business;
using Bacchus.Common.Resources;
using Microsoft.AspNetCore.Mvc;

namespace Bacchus.API.Controllers;

[Produces("application/json")]
[Route("api/roles")]
public class RoleController : Controller
{
    private readonly IService<RoleResource> _roleService;

    public RoleController(IService<RoleResource> roleService)
    {
        _roleService = roleService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetItemById(int id)
    {
        RoleResource roleResource = await _roleService.GetItemById(id);

        if (roleResource != null)
        {
            return Ok(roleResource);
        }

        return NotFound();
    }
}
