using AutoMapper;
using Bacchus.Business;
using Bacchus.Common.Entities;
using Bacchus.Common.Resources;
using Bacchus.DataAccess.UnitOfWork.Repositories;
using Bacchus.DataAccess.UnitOfWork;

namespace Bacchus.Service;

public class WineFamilyService : IService<WineFamilyResource>
{
    private readonly IRepository<WineFamilyEntity> _repository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public WineFamilyService(IRepository<WineFamilyEntity> repository, IMapper mapper, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<WineFamilyResource> Add(WineFamilyResource wineFamilyResource)
    {
        WineFamilyEntity newWineFamily = _mapper.Map<WineFamilyEntity>(wineFamilyResource);
        _repository.Add(newWineFamily);
        await _unitOfWork.SaveIntoDbContextAsync();
        return wineFamilyResource;
    }

    public async Task Delete(int id)
    {
        WineFamilyEntity wineFamilyEntity = _repository.GetOne(id);

        if (wineFamilyEntity != null)
        {
            _repository.Remove(wineFamilyEntity);
        }

        await _unitOfWork.SaveIntoDbContextAsync();
    }

    public Task<List<WineFamilyResource>> GetAll()
    {
        List<WineFamilyEntity> wineFamilyEntities = _repository.GetAll();
        List<WineFamilyResource> wineFamilyResources = _mapper.Map<List<WineFamilyResource>>(wineFamilyEntities);
        return Task.FromResult(wineFamilyResources);
    }

    public Task<WineFamilyResource> GetItemById(int id)
    {
        WineFamilyEntity wineFamilyEntity = _repository.GetOne(id);
        WineFamilyResource wineFamilyResource = _mapper.Map<WineFamilyEntity, WineFamilyResource>(wineFamilyEntity);
        return Task.FromResult(wineFamilyResource);
    }

    public async Task<WineFamilyResource> Update(WineFamilyResource wineFamilyResource)
    {
        WineFamilyEntity wineFamilyEntity = _repository.GetOne(wineFamilyResource.Id);

        if (wineFamilyEntity == null)
        {
            throw new Exception("WineFamily doesn't exist.");
        }

        WineFamilyEntity updatedWineFamilyEntity = _mapper.Map(wineFamilyResource, wineFamilyEntity);
        _repository.Update(updatedWineFamilyEntity);
        await _unitOfWork.SaveIntoDbContextAsync();
        WineFamilyResource updatedWineFamilyResource = _mapper.Map<WineFamilyEntity, WineFamilyResource>(updatedWineFamilyEntity);
        return updatedWineFamilyResource;
    }
}
