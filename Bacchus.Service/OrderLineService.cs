using AutoMapper;
using Bacchus.Business;
using Bacchus.Common.Entities;
using Bacchus.Common.Resources;
using Bacchus.DataAccess.UnitOfWork.Repositories;
using Bacchus.DataAccess.UnitOfWork;

namespace Bacchus.Service;

public class OrderLineService : IService<OrderLineResource>
{
    private readonly IRepository<OrderLineEntity> _repository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public OrderLineService(IRepository<OrderLineEntity> repository, IMapper mapper, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<OrderLineResource> Add(OrderLineResource orderLineResource)
    {
        OrderLineEntity newOrderLine = _mapper.Map<OrderLineEntity>(orderLineResource);
        _repository.Add(newOrderLine);
        await _unitOfWork.SaveIntoDbContextAsync();
        return orderLineResource;
    }

    public async Task Delete(int id)
    {
        OrderLineEntity orderLineEntity = _repository.GetOne(id);

        if (orderLineEntity != null)
        {
            _repository.Remove(orderLineEntity);
        }

        await _unitOfWork.SaveIntoDbContextAsync();
    }

    public Task<List<OrderLineResource>> GetAll()
    {
        List<OrderLineEntity> orderLineEntities = _repository.GetAll();
        List<OrderLineResource> orderLineResources = _mapper.Map<List<OrderLineResource>>(orderLineEntities);
        return Task.FromResult(orderLineResources);
    }

    public Task<OrderLineResource> GetItemById(int id)
    {
        OrderLineEntity orderLineEntity = _repository.GetOne(id);
        OrderLineResource orderLineResource = _mapper.Map<OrderLineEntity, OrderLineResource>(orderLineEntity);
        return Task.FromResult(orderLineResource);
    }

    public async Task<OrderLineResource> Update(OrderLineResource orderLineResource)
    {
        OrderLineEntity orderLineEntity = _repository.GetOne(orderLineResource.Id);

        if (orderLineEntity == null)
        {
            throw new Exception("OrderLine doesn't exist.");
        }

        OrderLineEntity updatedOrderLineEntity = _mapper.Map(orderLineResource, orderLineEntity);
        _repository.Update(updatedOrderLineEntity);
        await _unitOfWork.SaveIntoDbContextAsync();
        OrderLineResource updatedOrderLineResource = _mapper.Map<OrderLineEntity, OrderLineResource>(updatedOrderLineEntity);
        return updatedOrderLineResource;
    }
}
