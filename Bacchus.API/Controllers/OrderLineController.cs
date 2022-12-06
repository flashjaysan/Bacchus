using Bacchus.Business;
using Bacchus.Common.Resources;
using Microsoft.AspNetCore.Mvc;

namespace Bacchus.API.Controllers;

[Produces("application/json")]
[Route("api/orderlines")]
public class OrderLineController : Controller
{
    private readonly IService<OrderLineResource> _orderLineService;

    public OrderLineController(IService<OrderLineResource> orderLineService)
    {
        _orderLineService = orderLineService;
    }

    [HttpGet("{id}")]
    public async Task<OrderLineResource> GetItemById(int id)
    {
        return await _orderLineService.GetItemById(id);
    }

    [HttpGet]
    public async Task<List<OrderLineResource>> GetAll()
    {
        return await _orderLineService.GetAll();
    }

    [HttpPost]
    public async Task<OrderLineResource> Add(OrderLineResource orderLineResource)
    {
        return await _orderLineService.Add(orderLineResource);
    }

    [HttpPut]
    public async Task<OrderLineResource> Update(OrderLineResource orderLineResource)
    {
        return await _orderLineService.Update(orderLineResource);
    }

    [HttpDelete("{id}")]
    public async Task Delete(int id)
    {
        await _orderLineService.Delete(id);
    }
}
