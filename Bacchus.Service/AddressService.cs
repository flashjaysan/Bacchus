using AutoMapper;
using Bacchus.Business;
using Bacchus.Common.Entities;
using Bacchus.Common.Resources;
using Bacchus.DataAccess.UnitOfWork.Repositories;
using Bacchus.DataAccess.UnitOfWork;
using Bacchus.Common.Core;

namespace Bacchus.Service;

public class AddressService : IService<AddressResource>
{
    private readonly IRepository<AddressEntity> _repository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public AddressService(IRepository<AddressEntity> repository, IMapper mapper, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<AddressResource> Add(Resource addressResource)
    {
        var request = (AddressResource)addressResource;
        AddressEntity newAddress = _mapper.Map<AddressEntity>(addressResource);
        _repository.Add(newAddress);
        await _unitOfWork.SaveIntoDbContextAsync();
        var result = _mapper.Map<AddressResource>(newAddress);
        return result;
    }

    public async Task Delete(int id)
    {
        AddressEntity addressEntity = _repository.GetOne(id);

        if (addressEntity != null)
        {
            _repository.Remove(addressEntity);
        }

        await _unitOfWork.SaveIntoDbContextAsync();
    }

    public Task<List<AddressResource>> GetAll()
    {
        List<AddressEntity> addressEntities = _repository.GetAll();
        List<AddressResource> addressResources = _mapper.Map<List<AddressResource>>(addressEntities);
        return Task.FromResult(addressResources);
    }

    public Task<AddressResource> GetItemById(int id)
    {
        AddressEntity addressEntity = _repository.GetOne(id);
        AddressResource addressResource = _mapper.Map<AddressEntity, AddressResource>(addressEntity);
        return Task.FromResult(addressResource);
    }

    public async Task<AddressResource> Update(Resource addressResource)
    {
        AddressEntity addressEntity = _repository.GetOne(addressResource.Id);

        if (addressEntity == null)
        {
            throw new Exception("Address doesn't exist.");
        }

        AddressEntity updatedAddressEntity = _mapper.Map(addressResource, addressEntity);
        _repository.Update(updatedAddressEntity);
        await _unitOfWork.SaveIntoDbContextAsync();
        AddressResource updatedAddressResource = _mapper.Map<AddressEntity, AddressResource>(updatedAddressEntity);
        return updatedAddressResource;
    }
}
