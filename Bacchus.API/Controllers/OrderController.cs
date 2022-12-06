using Bacchus.Business;
using Bacchus.Common.Resources;
using Microsoft.AspNetCore.Mvc;

namespace Bacchus.API.Controllers;

public class OrderController : Controller
{
    private readonly IService<OrderResource> _orderService;

    public OrderController(IService<OrderResource> orderService)
    {
        _orderService = orderService;
    }
}
