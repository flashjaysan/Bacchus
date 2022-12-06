using Bacchus.Business;
using Bacchus.Common.Resources;
using Microsoft.AspNetCore.Mvc;

namespace Bacchus.API.Controllers;

[Produces("application/json")]
[Route("api/grapevarieties")]
public class GrapeVarietyController : Controller
{
    private readonly IService<GrapeVarietyResource> _grapeVarietyService;

    public GrapeVarietyController(IService<GrapeVarietyResource> grapeVarietyService)
    {
        _grapeVarietyService = grapeVarietyService;
    }
}
