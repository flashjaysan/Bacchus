﻿using Bacchus.Business;
using Bacchus.Common.Resources;
using Microsoft.AspNetCore.Mvc;

namespace Bacchus.API.Controllers;

[Produces("application/json")]
[Route("api/roles")]
public class RoleController : Controller
{
    private readonly IService<RoleResource> _roleService;

    public RoleController(IService<RoleResource> roleService)
    {
        _roleService = roleService;
    }
}
