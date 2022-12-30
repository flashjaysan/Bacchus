using AutoMapper;
using Bacchus.Business;
using Bacchus.Common.Entities;
using Bacchus.Common.Resources;
using Bacchus.DataAccess.UnitOfWork.Repositories;
using Bacchus.DataAccess.UnitOfWork;

namespace Bacchus.Service;

public class SupplierWineService : IService<SupplierWineResource>
{
    private readonly IRepository<SupplierWineEntity> _repository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public SupplierWineService(IRepository<SupplierWineEntity> repository, IMapper mapper, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<SupplierWineResource> Add(SupplierWineResource supplierWineResource)
    {
        SupplierWineEntity newSupplierWine = _mapper.Map<SupplierWineEntity>(supplierWineResource);
        _repository.Add(newSupplierWine);
        await _unitOfWork.SaveIntoDbContextAsync();
        return supplierWineResource;
    }

    public async Task Delete(int id)
    {
        SupplierWineEntity supplierWineEntity = _repository.GetOne(id);

        if (supplierWineEntity != null)
        {
            _repository.Remove(supplierWineEntity);
        }

        await _unitOfWork.SaveIntoDbContextAsync();
    }

    public Task<List<SupplierWineResource>> GetAll()
    {
        List<SupplierWineEntity> supplierWineEntities = _repository.GetAll();
        List<SupplierWineResource> supplierWineResources = _mapper.Map<List<SupplierWineResource>>(supplierWineEntities);
        return Task.FromResult(supplierWineResources);
    }

    public Task<SupplierWineResource> GetItemById(int id)
    {
        SupplierWineEntity supplierWineEntity = _repository.GetOne(id);
        SupplierWineResource supplierWineResource = _mapper.Map<SupplierWineEntity, SupplierWineResource>(supplierWineEntity);
        return Task.FromResult(supplierWineResource);
    }

    public async Task<SupplierWineResource> Update(SupplierWineResource supplierWineResource)
    {
        SupplierWineEntity supplierWineEntity = _repository.GetOne(supplierWineResource.Id);

        if (supplierWineEntity == null)
        {
            throw new Exception("Supplier doesn't exist.");
        }

        SupplierWineEntity updatedSupplierWineEntity = _mapper.Map(supplierWineResource, supplierWineEntity);
        _repository.Update(updatedSupplierWineEntity);
        await _unitOfWork.SaveIntoDbContextAsync();
        SupplierWineResource updatedSupplierWineResource = _mapper.Map<SupplierWineEntity, SupplierWineResource>(updatedSupplierWineEntity);
        return updatedSupplierWineResource;
    }
}
