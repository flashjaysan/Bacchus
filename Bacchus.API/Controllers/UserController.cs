using Bacchus.Business;
using Bacchus.Common.Resources;
using Microsoft.AspNetCore.Mvc;

namespace Bacchus.API.Controllers;

[Produces("application/json")]
[Route("api/users")]
public class UserController : Controller
{
    private readonly IService<UserResource> _userService;

    public UserController(IService<UserResource> userService)
    {
        _userService = userService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetItemById(int id)
    {
        UserResource userResource = await _userService.GetItemById(id);

        if (userResource != null)
        {
            return Ok(userResource);
        }

        return NotFound();
    }
}
