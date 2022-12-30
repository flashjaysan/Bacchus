using Bacchus.Business;
using Bacchus.Common.Resources;
using Microsoft.AspNetCore.Mvc;

namespace Bacchus.API.Controllers;

[Produces("application/json")]
[Route("api/orderlines")]
public class OrderLineController : Controller
{
    private readonly IService<OrderWineResource> _orderLineService;

    public OrderLineController(IService<OrderWineResource> orderLineService)
    {
        _orderLineService = orderLineService;
    }

    [HttpGet("{id}")]
    public async Task<OrderWineResource> GetItemById(int id)
    {
        return await _orderLineService.GetItemById(id);
    }

    [HttpGet]
    public async Task<List<OrderWineResource>> GetAll()
    {
        return await _orderLineService.GetAll();
    }

    [HttpPost]
    public async Task<OrderWineResource> Add(OrderWineResource orderLineResource)
    {
        return await _orderLineService.Add(orderLineResource);
    }

    [HttpPut]
    public async Task<OrderWineResource> Update(OrderWineResource orderLineResource)
    {
        return await _orderLineService.Update(orderLineResource);
    }

    [HttpDelete("{id}")]
    public async Task Delete(int id)
    {
        await _orderLineService.Delete(id);
    }
}
