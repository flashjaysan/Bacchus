using Microsoft.AspNetCore.Mvc;

namespace Bacchus.API.Controllers;

public class RoleController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
