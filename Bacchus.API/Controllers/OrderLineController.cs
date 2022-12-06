using Microsoft.AspNetCore.Mvc;

namespace Bacchus.API.Controllers;

public class OrderLineController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
