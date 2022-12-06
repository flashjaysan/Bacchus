using Bacchus.Business;
using Bacchus.Common.Resources;
using Microsoft.AspNetCore.Mvc;

namespace Bacchus.API.Controllers;

public class UserController : Controller
{
    private readonly IService<UserResource> _userService;

    public UserController(IService<UserResource> userService)
    {
        _userService = userService;
    }
}
