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
    public async Task<AddressResource> GetItemById(int id)
    {
        return await _addressService.GetItemById(id);
    }

    [HttpGet]
    public async Task<List<AddressResource>> GetAll()
    {
        return await _addressService.GetAll();
    }

    [HttpPost]
    public async Task<AddressResource> Add(AddressResource addressResource)
    {
        return await _addressService.Add(addressResource);
    }

    [HttpPut]
    public async Task<AddressResource> Update(AddressResource addressResource)
    {
        return await _addressService.Update(addressResource);
    }

    [HttpDelete("{id}")]
    public async Task Delete(int id)
    {
        await _addressService.Delete(id);
    }
}
