using Microsoft.AspNetCore.Mvc;

namespace Bacchus.API.Controllers;

public class UserRoleController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
