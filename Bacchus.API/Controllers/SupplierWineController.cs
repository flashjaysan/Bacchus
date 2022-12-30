using Bacchus.Business;
using Bacchus.Common.Resources;
using Microsoft.AspNetCore.Mvc;

namespace Bacchus.API.Controllers;

[Produces("application/json")]
[Route("api/supplierswines")]
public class SupplierWineController : Controller
{
    private readonly IService<SupplierWineResource> _supplierWineService;

    public SupplierWineController(IService<SupplierWineResource> supplierWineService)
    {
        _supplierWineService = supplierWineService;
    }

    [HttpGet("{id}")]
    public async Task<SupplierWineResource> GetItemById(int id)
    {
        return await _supplierWineService.GetItemById(id);
    }

    [HttpGet]
    public async Task<List<SupplierWineResource>> GetAll()
    {
        return await _supplierWineService.GetAll();
    }

    [HttpPost]
    public async Task<SupplierWineResource> Add([FromBody] SupplierWineResource supplierWineResource)
    {
        return await _supplierWineService.Add(supplierWineResource);
    }

    [HttpPut]
    public async Task<SupplierWineResource> Update([FromBody] SupplierWineResource supplierWineResource)
    {
        return await _supplierWineService.Update(supplierWineResource);
    }

    [HttpDelete("{id}")]
    public async Task Delete(int id)
    {
        await _supplierWineService.Delete(id);
    }
}
