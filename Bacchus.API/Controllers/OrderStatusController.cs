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
}
