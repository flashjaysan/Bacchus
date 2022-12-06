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
}
