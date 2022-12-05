using AutoMapper;
using Bacchus.Business;
using Bacchus.Common.Entities;
using Bacchus.Common.Resources;
using Bacchus.DataAccess.UnitOfWork.Repositories;
using Bacchus.DataAccess.UnitOfWork;

namespace Bacchus.Service;

public class OrderService : IService<OrderResource>
{
    private readonly IRepository<OrderEntity> _repository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public OrderService(IRepository<OrderEntity> repository, IMapper mapper, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<OrderResource> Add(OrderResource orderResource)
    {
        OrderEntity newOrder = _mapper.Map<OrderEntity>(orderResource);
        _repository.Add(newOrder);
        await _unitOfWork.SaveIntoDbContextAsync();
        return orderResource;
    }

    public async Task Delete(int id)
    {
        OrderEntity orderEntity = _repository.GetOne(id);

        if (orderEntity != null)
        {
            _repository.Remove(orderEntity);
        }

        await _unitOfWork.SaveIntoDbContextAsync();
    }

    public Task<List<OrderResource>> GetAll()
    {
        List<OrderEntity> orderEntities = _repository.GetAll();
        List<OrderResource> orderResources = _mapper.Map<List<OrderResource>>(orderEntities);
        return Task.FromResult(orderResources);
    }

    public Task<OrderResource> GetItemById(int id)
    {
        OrderEntity orderEntity = _repository.GetOne(id);
        OrderResource orderResource = _mapper.Map<OrderEntity, OrderResource>(orderEntity);
        return Task.FromResult(orderResource);
    }

    public async Task<OrderResource> Update(OrderResource orderResource)
    {
        OrderEntity orderEntity = _repository.GetOne(orderResource.Id);

        if (orderEntity == null)
        {
            throw new Exception("Order doesn't exist.");
        }

        OrderEntity updatedOrderEntity = _mapper.Map(orderResource, orderEntity);
        _repository.Update(updatedOrderEntity);
        await _unitOfWork.SaveIntoDbContextAsync();
        OrderResource updatedOrderResource = _mapper.Map<OrderEntity, OrderResource>(updatedOrderEntity);
        return updatedOrderResource;
    }
}
