using Microsoft.AspNetCore.Mvc;

namespace Bacchus.API.Controllers;

public class SupplierController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
