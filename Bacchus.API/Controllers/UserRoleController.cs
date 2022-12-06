﻿using Bacchus.Business;
using Bacchus.Common.Resources;
using Microsoft.AspNetCore.Mvc;

namespace Bacchus.API.Controllers;

[Produces("application/json")]
[Route("api/usersroles")]
public class UserRoleController : Controller
{
    private readonly IService<UserRoleResource> _userRoleService;

    public UserRoleController(IService<UserRoleResource> userRoleService)
    {
        _userRoleService = userRoleService;
    }

    [HttpGet("{id}")]
    public async Task<UserRoleResource> GetItemById(int id)
    {
        return await _userRoleService.GetItemById(id);
    }

    [HttpGet]
    public async Task<List<UserRoleResource>> GetAll()
    {
        return await _userRoleService.GetAll();
    }

    [HttpPost]
    public async Task<UserRoleResource> Add(UserRoleResource userRoleResource)
    {
        return await _userRoleService.Add(userRoleResource);
    }

    [HttpPut]
    public async Task<UserRoleResource> Update(UserRoleResource userRoleResource)
    {
        return await _userRoleService.Update(userRoleResource);
    }

    [HttpDelete("{id}")]
    public async Task Delete(int id)
    {
        await _userRoleService.Delete(id);
    }
}
