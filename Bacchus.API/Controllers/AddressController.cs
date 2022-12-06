using Bacchus.Business;
using Bacchus.Common.Resources;
using Microsoft.AspNetCore.Mvc;

namespace Bacchus.API.Controllers;

[Produces("application/json")]
[Route("api/addresses")]
public class AddressController : Controller
{
    private readonly IService<AddressResource> _addressService;

    public AddressController(IService<AddressResource> addressService)
    {
        _addressService = addressService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetItemById(int id)
    {
        AddressResource addressResource = await _addressService.GetItemById(id);

        if (addressResource != null)
        {
            return Ok(addressResource);
        }

        return NotFound();
    }
}
