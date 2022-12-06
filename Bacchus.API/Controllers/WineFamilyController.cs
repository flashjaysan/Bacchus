using Microsoft.AspNetCore.Mvc;

namespace Bacchus.API.Controllers;

public class WineFamilyController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
