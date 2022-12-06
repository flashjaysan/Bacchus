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
    public async Task<IActionResult> GetItemById(int id)
    {
        OrderTypeResource orderTypeResource = await _orderTypeService.GetItemById(id);

        if (orderTypeResource != null)
        {
            return Ok(orderTypeResource);
        }

        return NotFound();
    }
}
