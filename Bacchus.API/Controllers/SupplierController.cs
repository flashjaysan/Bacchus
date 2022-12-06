﻿using Bacchus.Business;
using Bacchus.Common.Resources;
using Microsoft.AspNetCore.Mvc;

namespace Bacchus.API.Controllers;

public class SupplierController : Controller
{
    private readonly IService<SupplierResource> _supplierService;

    public SupplierController(IService<SupplierResource> supplierService)
    {
        _supplierService = supplierService;
    }
}
