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
    public async Task<IActionResult> GetItemById(int id)
    {
        OrderResource orderResource = await _orderService.GetItemById(id);

        if (orderResource != null)
        {
            return Ok(orderResource);
        }

        return NotFound();
    }
}
