using Microsoft.AspNetCore.Mvc;

namespace Bacchus.API.Controllers;

public class GrapeVarietyController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
