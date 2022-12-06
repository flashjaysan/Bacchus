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
}
