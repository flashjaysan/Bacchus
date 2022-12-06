using Bacchus.Business;
using Bacchus.Common.Resources;
using Microsoft.AspNetCore.Mvc;

namespace Bacchus.API.Controllers;

[Produces("application/json")]
[Route("api/ordertypes")]
public class OrderTypeController : Controller
{
    private readonly IService<OrderTypeResource> _orderTypeService;

    public OrderTypeController(IService<OrderTypeResource> orderTypeService)
    {
        _orderTypeService = orderTypeService;
    }

    [HttpGet("{id}")]
    public async Task<OrderTypeResource> GetItemById(int id)
    {
        return await _orderTypeService.GetItemById(id);
    }

    [HttpGet]
    public async Task<List<OrderTypeResource>> GetAll()
    {
        return await _orderTypeService.GetAll();
    }

    [HttpPost]
    public async Task<OrderTypeResource> Add(OrderTypeResource orderTypeResource)
    {
        return await _orderTypeService.Add(orderTypeResource);
    }

    [HttpPut]
    public async Task<OrderTypeResource> Update(OrderTypeResource orderTypeResource)
    {
        return await _orderTypeService.Update(orderTypeResource);
    }

    [HttpDelete("{id}")]
    public async Task Delete(int id)
    {
        await _orderTypeService.Delete(id);
    }
}
