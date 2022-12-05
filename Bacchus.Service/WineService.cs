using AutoMapper;
using Bacchus.Business;
using Bacchus.Common.Entities;
using Bacchus.Common.Resources;
using Bacchus.DataAccess.UnitOfWork.Repositories;
using Bacchus.DataAccess.UnitOfWork;

namespace Bacchus.Service;

public class WineService : IService<WineResource>
{
    private readonly IRepository<WineEntity> _repository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public WineService(IRepository<WineEntity> repository, IMapper mapper, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<WineResource> Add(WineResource wineResource)
    {
        WineEntity newWine = _mapper.Map<WineEntity>(wineResource);
        _repository.Add(newWine);
        await _unitOfWork.SaveIntoDbContextAsync();
        return wineResource;
    }

    public async Task Delete(int id)
    {
        WineEntity wineEntity = _repository.GetOne(id);

        if (wineEntity != null)
        {
            _repository.Remove(wineEntity);
        }

        await _unitOfWork.SaveIntoDbContextAsync();
    }

    public Task<List<WineResource>> GetAll()
    {
        List<WineEntity> wineEntities = _repository.GetAll();
        List<WineResource> wineResources = _mapper.Map<List<WineResource>>(wineEntities);
        return Task.FromResult(wineResources);
    }

    public Task<WineResource> GetItemById(int id)
    {
        WineEntity wineEntity = _repository.GetOne(id);
        WineResource wineResource = _mapper.Map<WineEntity, WineResource>(wineEntity);
        return Task.FromResult(wineResource);
    }

    public async Task<WineResource> Update(WineResource wineResource)
    {
        WineEntity wineEntity = _repository.GetOne(wineResource.Id);

        if (wineEntity == null)
        {
            throw new Exception("Wine doesn't exist.");
        }

        WineEntity updatedWineEntity = _mapper.Map(wineResource, wineEntity);
        _repository.Update(updatedWineEntity);
        await _unitOfWork.SaveIntoDbContextAsync();
        WineResource updatedWineResource = _mapper.Map<WineEntity, WineResource>(updatedWineEntity);
        return updatedWineResource;
    }
}
