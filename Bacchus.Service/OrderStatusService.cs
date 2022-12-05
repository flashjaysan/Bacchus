using AutoMapper;
using Bacchus.Business;
using Bacchus.Common.Entities;
using Bacchus.Common.Resources;
using Bacchus.DataAccess.UnitOfWork.Repositories;
using Bacchus.DataAccess.UnitOfWork;

namespace Bacchus.Service;

public class OrderStatusService : IService<OrderStatusResource>
{
    private readonly IRepository<OrderStatusEntity> _repository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public OrderStatusService(IRepository<OrderStatusEntity> repository, IMapper mapper, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<OrderStatusResource> Add(OrderStatusResource orderStatusResource)
    {
        OrderStatusEntity newOrderStatus = _mapper.Map<OrderStatusEntity>(orderStatusResource);
        _repository.Add(newOrderStatus);
        await _unitOfWork.SaveIntoDbContextAsync();
        return orderStatusResource;
    }

    public async Task Delete(int id)
    {
        OrderStatusEntity orderStatusEntity = _repository.GetOne(id);

        if (orderStatusEntity != null)
        {
            _repository.Remove(orderStatusEntity);
        }

        await _unitOfWork.SaveIntoDbContextAsync();
    }

    public Task<List<OrderStatusResource>> GetAll()
    {
        List<OrderStatusEntity> orderStatusEntities = _repository.GetAll();
        List<OrderStatusResource> orderStatusResources = _mapper.Map<List<OrderStatusResource>>(orderStatusEntities);
        return Task.FromResult(orderStatusResources);
    }

    public Task<OrderStatusResource> GetItemById(int id)
    {
        OrderStatusEntity orderStatusEntity = _repository.GetOne(id);
        OrderStatusResource orderStatusResource = _mapper.Map<OrderStatusEntity, OrderStatusResource>(orderStatusEntity);
        return Task.FromResult(orderStatusResource);
    }

    public async Task<OrderStatusResource> Update(OrderStatusResource orderStatusResource)
    {
        OrderStatusEntity orderStatusEntity = _repository.GetOne(orderStatusResource.Id);

        if (orderStatusEntity == null)
        {
            throw new Exception("OrderStatus doesn't exist.");
        }

        OrderStatusEntity updatedOrderStatusEntity = _mapper.Map(orderStatusResource, orderStatusEntity);
        _repository.Update(updatedOrderStatusEntity);
        await _unitOfWork.SaveIntoDbContextAsync();
        OrderStatusResource updatedOrderStatusResource = _mapper.Map<OrderStatusEntity, OrderStatusResource>(updatedOrderStatusEntity);
        return updatedOrderStatusResource;
    }
}
