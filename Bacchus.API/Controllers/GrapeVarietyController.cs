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

    [HttpGet("{id}")]
    public async Task<GrapeVarietyResource> GetItemById(int id)
    {
        return await _grapeVarietyService.GetItemById(id);
    }

    [HttpGet]
    public async Task<List<GrapeVarietyResource>> GetAll()
    {
        return await _grapeVarietyService.GetAll();
    }

    [HttpPost]
    public async Task<GrapeVarietyResource> Add(GrapeVarietyResource grapeVarietyResource)
    {
        return await _grapeVarietyService.Add(grapeVarietyResource);
    }

    [HttpPut]
    public async Task<GrapeVarietyResource> Update(GrapeVarietyResource grapeVarietyResource)
    {
        return await _grapeVarietyService.Update(grapeVarietyResource);
    }

    [HttpDelete("{id}")]
    public async Task Delete(int id)
    {
        await _grapeVarietyService.Delete(id);
    }
}
