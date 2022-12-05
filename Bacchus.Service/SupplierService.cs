using AutoMapper;
using Bacchus.Business;
using Bacchus.Common.Entities;
using Bacchus.Common.Resources;
using Bacchus.DataAccess.UnitOfWork.Repositories;
using Bacchus.DataAccess.UnitOfWork;

namespace Bacchus.Service;

public class SupplierService : IService<SupplierResource>
{
    private readonly IRepository<SupplierEntity> _repository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public SupplierService(IRepository<SupplierEntity> repository, IMapper mapper, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<SupplierResource> Add(SupplierResource supplierResource)
    {
        SupplierEntity newSupplier = _mapper.Map<SupplierEntity>(supplierResource);
        _repository.Add(newSupplier);
        await _unitOfWork.SaveIntoDbContextAsync();
        return supplierResource;
    }

    public async Task Delete(int id)
    {
        SupplierEntity supplierEntity = _repository.GetOne(id);

        if (supplierEntity != null)
        {
            _repository.Remove(supplierEntity);
        }

        await _unitOfWork.SaveIntoDbContextAsync();
    }

    public Task<List<SupplierResource>> GetAll()
    {
        List<SupplierEntity> supplierEntities = _repository.GetAll();
        List<SupplierResource> supplierResources = _mapper.Map<List<SupplierResource>>(supplierEntities);
        return Task.FromResult(supplierResources);
    }

    public Task<SupplierResource> GetItemById(int id)
    {
        SupplierEntity supplierEntity = _repository.GetOne(id);
        SupplierResource supplierResource = _mapper.Map<SupplierEntity, SupplierResource>(supplierEntity);
        return Task.FromResult(supplierResource);
    }

    public async Task<SupplierResource> Update(SupplierResource supplierResource)
    {
        SupplierEntity supplierEntity = _repository.GetOne(supplierResource.Id);

        if (supplierEntity == null)
        {
            throw new Exception("Supplier doesn't exist.");
        }

        SupplierEntity updatedSupplierEntity = _mapper.Map(supplierResource, supplierEntity);
        _repository.Update(updatedSupplierEntity);
        await _unitOfWork.SaveIntoDbContextAsync();
        SupplierResource updatedSupplierResource = _mapper.Map<SupplierEntity, SupplierResource>(updatedSupplierEntity);
        return updatedSupplierResource;
    }
}
