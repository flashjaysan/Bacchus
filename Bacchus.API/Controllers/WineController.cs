using Bacchus.Business;
using Bacchus.Common.Resources;
using Microsoft.AspNetCore.Mvc;

namespace Bacchus.API.Controllers;

[Produces("application/json")]
[Route("api/wines")]
public class WineController : Controller
{
    private readonly IService<WineResource> _wineService;

    public WineController(IService<WineResource> wineService)
    {
        _wineService = wineService;
    }

    [HttpGet("{id}")]
    public async Task<WineResource> GetItemById(int id)
    {
        return await _wineService.GetItemById(id);
    }

    [HttpGet]
    public async Task<List<WineResource>> GetAll()
    {
        return await _wineService.GetAll();
    }

    [HttpPost]
    public async Task<WineResource> Add(WineResource wineResource)
    {
        return await _wineService.Add(wineResource);
    }

    [HttpPut]
    public async Task<WineResource> Update(WineResource wineResource)
    {
        return await _wineService.Update(wineResource);
    }

    [HttpDelete("{id}")]
    public async Task Delete(int id)
    {
        await _wineService.Delete(id);
    }
}
