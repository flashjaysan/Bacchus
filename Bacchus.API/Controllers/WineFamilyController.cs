using Bacchus.Business;
using Bacchus.Common.Resources;
using Microsoft.AspNetCore.Mvc;

namespace Bacchus.API.Controllers;

[Produces("application/json")]
[Route("api/winefamilies")]
public class WineFamilyController : Controller
{
    private readonly IService<WineFamilyResource> _wineFamilyService;

    public WineFamilyController(IService<WineFamilyResource> wineFamilyService)
    {
        _wineFamilyService = wineFamilyService;
    }

    [HttpGet("{id}")]
    public async Task<WineFamilyResource> GetItemById(int id)
    {
        return await _wineFamilyService.GetItemById(id);
    }

    [HttpGet]
    public async Task<List<WineFamilyResource>> GetAll()
    {
        return await _wineFamilyService.GetAll();
    }

    [HttpPost]
    public async Task<WineFamilyResource> Add(WineFamilyResource wineFamilyResource)
    {
        return await _wineFamilyService.Add(wineFamilyResource);
    }

    [HttpPut]
    public async Task<WineFamilyResource> Update(WineFamilyResource wineFamilyResource)
    {
        return await _wineFamilyService.Update(wineFamilyResource);
    }

    [HttpDelete("{id}")]
    public async Task Delete(int id)
    {
        await _wineFamilyService.Delete(id);
    }
}
