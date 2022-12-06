using Microsoft.AspNetCore.Mvc;

namespace Bacchus.API.Controllers;

public class WineController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
