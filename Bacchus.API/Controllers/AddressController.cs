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
    //FromBody add c'est plus un parametre d'url c'est dans le body json pour tout envoie de requête    a
    [HttpPost]
    public async Task<AddressResource> Add([FromBody] AddressResource addressResource) 
    {
        return await _addressService.Add(addressResource);
    }

    [HttpPut]
    public async Task<AddressResource> Update([FromBody] AddressResource addressResource)
    {
        return await _addressService.Update(addressResource);
    }

    [HttpDelete("{id}")]
    public async Task Delete(int id)
    {
        await _addressService.Delete(id);
    }
}
