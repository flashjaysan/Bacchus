﻿using Bacchus.Common.Entities;
using Bacchus.DataAccess.DbContext;
using System.Data;

namespace Bacchus.DataAccess.UnitOfWork.Repositories;

public class UserRepository : IRepository<UserEntity>
{
    private readonly BacchusDbContext _dbContext;

    public UserRepository(BacchusDbContext bacchusDbContext)
    {
        _dbContext = bacchusDbContext;
    }

    public void Add(UserEntity userEntity)
    {
        _dbContext.Users.Add(userEntity);
    }

    public List<UserEntity> GetAll()
    {
        return _dbContext.Users.ToList();
    }

    public UserEntity GetOne(int id)
    {
        return _dbContext.Users.FirstOrDefault(user => user.Id == id);
    }

    public void Remove(UserEntity userEntity)
    {
        _dbContext.Users.Remove(userEntity);
    }

    public void Update(UserEntity userEntity)
    {
        _dbContext.Users.Update(userEntity);
    }
}
