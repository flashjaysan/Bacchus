using Microsoft.AspNetCore.Mvc;

namespace Bacchus.API.Controllers;

public class OrderStatusController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
