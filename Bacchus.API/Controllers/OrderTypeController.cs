using Microsoft.AspNetCore.Mvc;

namespace Bacchus.API.Controllers;

public class OrderTypeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
