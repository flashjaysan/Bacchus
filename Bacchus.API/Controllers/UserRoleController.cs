using Bacchus.Business;
using Bacchus.Common.Resources;
using Microsoft.AspNetCore.Mvc;

namespace Bacchus.API.Controllers;

[Produces("application/json")]
[Route("api/usersroles")]
public class UserRoleController : Controller
{
    private readonly IService<UserRoleResource> _userRoleService;

    public UserRoleController(IService<UserRoleResource> userRoleService)
    {
        _userRoleService = userRoleService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetItemById(int id)
    {
        UserRoleResource userRoleResource = await _userRoleService.GetItemById(id);

        if (userRoleResource != null)
        {
            return Ok(userRoleResource);
        }

        return NotFound();
    }
}
