using AutoMapper;
using Bacchus.Business;
using Bacchus.Common.Entities;
using Bacchus.Common.Resources;
using Bacchus.DataAccess.UnitOfWork.Repositories;
using Bacchus.DataAccess.UnitOfWork;
using Bacchus.Common.Resources.Order;
using Bacchus.Common.Core;

namespace Bacchus.Service;

public class OrderService : IService<OrderResource>
{
    private readonly IRepository<OrderEntity> _repository;
    private readonly IRepository<WineEntity> _repositoryWine;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public OrderService(IRepository<OrderEntity> repository, IMapper mapper, IUnitOfWork unitOfWork, IRepository<WineEntity> repositoryWine)
    {
        _repository = repository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _repositoryWine = repositoryWine;
    }

    public async Task<OrderResource> Add(Resource orderResource)
    {
        var request = (OrderSaveResource)orderResource;
        var winesBd =  _repositoryWine.GetAll();
        ////TODO:check if wines exist
        
        OrderEntity newOrder = _mapper.Map<OrderEntity>(orderResource);
        request.WinesId.ForEach(wineId =>
        {
            var exist = winesBd.Any(x => x.Id == wineId);
            if (exist)
            {
                var OrderWine = new OrderWineEntity { WineId= wineId };
                newOrder.OrdersWines.Add(OrderWine);
            }
        });
        _repository.Add(newOrder);
        await _unitOfWork.SaveIntoDbContextAsync();
        var result = _mapper.Map<OrderResource>(newOrder);
        return result;
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

    public async Task<OrderResource> Update(Resource orderResource)
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
