using Microsoft.AspNetCore.Mvc;

namespace Bacchus.API.Controllers;

public class AddressController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
