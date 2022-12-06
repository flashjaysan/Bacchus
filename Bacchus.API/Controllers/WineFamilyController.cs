using Bacchus.Business;
using Bacchus.Common.Resources;
using Microsoft.AspNetCore.Mvc;

namespace Bacchus.API.Controllers;

public class WineFamilyController : Controller
{
    private readonly IService<WineFamilyResource> _wineFamilyService;

    public WineFamilyController(IService<WineFamilyResource> wineFamilyService)
    {
        _wineFamilyService = wineFamilyService;
    }
}
