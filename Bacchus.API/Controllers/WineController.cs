using Bacchus.Business;
using Bacchus.Common.Resources;
using Microsoft.AspNetCore.Mvc;

namespace Bacchus.API.Controllers;

public class WineController : Controller
{
    private readonly IService<WineResource> _wineService;

    public WineController(IService<WineResource> wineService)
    {
        _wineService = wineService;
    }
}
