using Bacchus.Business;
using Bacchus.Common.Resources;
using Microsoft.AspNetCore.Mvc;

namespace Bacchus.API.Controllers;

[Produces("application/json")]
[Route("api/suppliers")]
public class SupplierController : Controller
{
    private readonly IService<SupplierResource> _supplierService;

    public SupplierController(IService<SupplierResource> supplierService)
    {
        _supplierService = supplierService;
    }

    [HttpGet("{id}")]
    public async Task<SupplierResource> GetItemById(int id)
    {
        return await _supplierService.GetItemById(id);
    }

    [HttpGet]
    public async Task<List<SupplierResource>> GetAll()
    {
        return await _supplierService.GetAll();
    }

    [HttpPost]
    public async Task<SupplierResource> Add(SupplierResource supplierResource)
    {
        return await _supplierService.Add(supplierResource);
    }

    [HttpPut]
    public async Task<SupplierResource> Update(SupplierResource supplierResource)
    {
        return await _supplierService.Update(supplierResource);
    }

    [HttpDelete("{id}")]
    public async Task Delete(int id)
    {
        await _supplierService.Delete(id);
    }
}
