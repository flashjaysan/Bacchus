using Bacchus.Business;
using Bacchus.Common.Resources;
using Microsoft.AspNetCore.Mvc;

namespace Bacchus.API.Controllers;

[Produces("application/json")]
[Route("api/orderstatuses")]
public class OrderStatusController : Controller
{
    private readonly IService<OrderStatusResource> _orderStatusService;

    public OrderStatusController(IService<OrderStatusResource> orderStatusService)
    {
        _orderStatusService = orderStatusService;
    }

    [HttpGet("{id}")]
    public async Task<OrderStatusResource> GetItemById(int id)
    {
        return await _orderStatusService.GetItemById(id);
    }

    [HttpGet]
    public async Task<List<OrderStatusResource>> GetAll()
    {
        return await _orderStatusService.GetAll();
    }

    [HttpPost]
    public async Task<OrderStatusResource> Add(OrderStatusResource orderStatusResource)
    {
        return await _orderStatusService.Add(orderStatusResource);
    }

    [HttpPut]
    public async Task<OrderStatusResource> Update(OrderStatusResource orderStatusResource)
    {
        return await _orderStatusService.Update(orderStatusResource);
    }

    [HttpDelete("{id}")]
    public async Task Delete(int id)
    {
        await _orderStatusService.Delete(id);
    }
}
