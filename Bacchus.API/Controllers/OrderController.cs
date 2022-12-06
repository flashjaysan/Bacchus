using Bacchus.Business;
using Bacchus.Common.Resources;
using Microsoft.AspNetCore.Mvc;

namespace Bacchus.API.Controllers;

[Produces("application/json")]
[Route("api/orders")]
public class OrderController : Controller
{
    private readonly IService<OrderResource> _orderService;

    public OrderController(IService<OrderResource> orderService)
    {
        _orderService = orderService;
    }

    [HttpGet("{id}")]
    public async Task<OrderResource> GetItemById(int id)
    {
        return await _orderService.GetItemById(id);
    }

    [HttpGet]
    public async Task<List<OrderResource>> GetAll()
    {
        return await _orderService.GetAll();
    }

    [HttpPost]
    public async Task<OrderResource> Add(OrderResource orderResource)
    {
        return await _orderService.Add(orderResource);
    }

    [HttpPut]
    public async Task<OrderResource> Update(OrderResource orderResource)
    {
        return await _orderService.Update(orderResource);
    }

    [HttpDelete("{id}")]
    public async Task Delete(int id)
    {
        await _orderService.Delete(id);
    }
}
