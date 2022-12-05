using AutoMapper;
using Bacchus.Business;
using Bacchus.Common.Entities;
using Bacchus.Common.Resources;
using Bacchus.DataAccess.UnitOfWork.Repositories;
using Bacchus.DataAccess.UnitOfWork;

namespace Bacchus.Service;

public class GrapeVarietyService : IService<GrapeVarietyResource>
{
    private readonly IRepository<GrapeVarietyEntity> _repository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public GrapeVarietyService(IRepository<GrapeVarietyEntity> repository, IMapper mapper, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<GrapeVarietyResource> Add(GrapeVarietyResource grapeVarietyResource)
    {
        GrapeVarietyEntity newGrapeVariety = _mapper.Map<GrapeVarietyEntity>(grapeVarietyResource);
        _repository.Add(newGrapeVariety);
        await _unitOfWork.SaveIntoDbContextAsync();
        return grapeVarietyResource;
    }

    public async Task Delete(int id)
    {
        GrapeVarietyEntity grapeVarietyEntity = _repository.GetOne(id);

        if (grapeVarietyEntity != null)
        {
            _repository.Remove(grapeVarietyEntity);
        }

        await _unitOfWork.SaveIntoDbContextAsync();
    }

    public Task<List<GrapeVarietyResource>> GetAll()
    {
        List<GrapeVarietyEntity> grapeVarietyEntities = _repository.GetAll();
        List<GrapeVarietyResource> grapeVarietyResources = _mapper.Map<List<GrapeVarietyResource>>(grapeVarietyEntities);
        return Task.FromResult(grapeVarietyResources);
    }

    public Task<GrapeVarietyResource> GetItemById(int id)
    {
        GrapeVarietyEntity grapeVarietyEntity = _repository.GetOne(id);
        GrapeVarietyResource grapeVarietyResource = _mapper.Map<GrapeVarietyEntity, GrapeVarietyResource>(grapeVarietyEntity);
        return Task.FromResult(grapeVarietyResource);
    }

    public async Task<GrapeVarietyResource> Update(GrapeVarietyResource grapeVarietyResource)
    {
        GrapeVarietyEntity grapeVarietyEntity = _repository.GetOne(grapeVarietyResource.Id);

        if (grapeVarietyEntity == null)
        {
            throw new Exception("GrapeVariety doesn't exist.");
        }

        GrapeVarietyEntity updatedGrapeVarietyEntity = _mapper.Map(grapeVarietyResource, grapeVarietyEntity);
        _repository.Update(updatedGrapeVarietyEntity);
        await _unitOfWork.SaveIntoDbContextAsync();
        GrapeVarietyResource updatedGrapeVarietyResource = _mapper.Map<GrapeVarietyEntity, GrapeVarietyResource>(updatedGrapeVarietyEntity);
        return updatedGrapeVarietyResource;
    }
}
