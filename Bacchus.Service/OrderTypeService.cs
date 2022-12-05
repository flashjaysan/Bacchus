using AutoMapper;
using Bacchus.Business;
using Bacchus.Common.Entities;
using Bacchus.Common.Resources;
using Bacchus.DataAccess.UnitOfWork.Repositories;
using Bacchus.DataAccess.UnitOfWork;

namespace Bacchus.Service;

public class OrderTypeService : IService<OrderTypeResource>
{
    private readonly IRepository<OrderTypeEntity> _repository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public OrderTypeService(IRepository<OrderTypeEntity> repository, IMapper mapper, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<OrderTypeResource> Add(OrderTypeResource orderTypeResource)
    {
        OrderTypeEntity newOrderType = _mapper.Map<OrderTypeEntity>(orderTypeResource);
        _repository.Add(newOrderType);
        await _unitOfWork.SaveIntoDbContextAsync();
        return orderTypeResource;
    }

    public async Task Delete(int id)
    {
        OrderTypeEntity orderTypeEntity = _repository.GetOne(id);

        if (orderTypeEntity != null)
        {
            _repository.Remove(orderTypeEntity);
        }

        await _unitOfWork.SaveIntoDbContextAsync();
    }

    public Task<List<OrderTypeResource>> GetAll()
    {
        List<OrderTypeEntity> orderTypeEntities = _repository.GetAll();
        List<OrderTypeResource> orderTypeResources = _mapper.Map<List<OrderTypeResource>>(orderTypeEntities);
        return Task.FromResult(orderTypeResources);
    }

    public Task<OrderTypeResource> GetItemById(int id)
    {
        OrderTypeEntity orderTypeEntity = _repository.GetOne(id);
        OrderTypeResource orderTypeResource = _mapper.Map<OrderTypeEntity, OrderTypeResource>(orderTypeEntity);
        return Task.FromResult(orderTypeResource);
    }

    public async Task<OrderTypeResource> Update(OrderTypeResource orderTypeResource)
    {
        OrderTypeEntity orderTypeEntity = _repository.GetOne(orderTypeResource.Id);

        if (orderTypeEntity == null)
        {
            throw new Exception("OrderType doesn't exist.");
        }

        OrderTypeEntity updatedOrderTypeEntity = _mapper.Map(orderTypeResource, orderTypeEntity);
        _repository.Update(updatedOrderTypeEntity);
        await _unitOfWork.SaveIntoDbContextAsync();
        OrderTypeResource updatedOrderTypeResource = _mapper.Map<OrderTypeEntity, OrderTypeResource>(updatedOrderTypeEntity);
        return updatedOrderTypeResource;
    }
}
