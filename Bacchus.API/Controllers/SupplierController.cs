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
    public async Task<IActionResult> GetItemById(int id)
    {
        SupplierResource supplierResource = await _supplierService.GetItemById(id);

        if (supplierResource != null)
        {
            return Ok(supplierResource);
        }

        return NotFound();
    }
}
