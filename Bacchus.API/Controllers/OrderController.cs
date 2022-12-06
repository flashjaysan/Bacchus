using Microsoft.AspNetCore.Mvc;

namespace Bacchus.API.Controllers;

public class OrderController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
