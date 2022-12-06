using Bacchus.Business;
using Bacchus.Common.Resources;
using Microsoft.AspNetCore.Mvc;

namespace Bacchus.API.Controllers;

public class UserRoleController : Controller
{
    private readonly IService<UserRoleResource> _userRoleService;

    public UserRoleController(IService<UserRoleResource> userRoleService)
    {
        _userRoleService = userRoleService;
    }
}
