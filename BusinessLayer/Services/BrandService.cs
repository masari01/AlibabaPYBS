using AlibabaPBYS.Core.Interfaces.Repository;
using AlibabaPBYS.Core.Interfaces.Services;
using AlibabaPBYS.Core.Models;
using AutoMapper;

namespace AlibabaPBYS.BusinessLayer.Services;

public class BrandService : IBrandService
{
    private readonly IBrandRepository _brandRepository;
    private readonly IMapper _mapper;
    public BrandService(IBrandRepository brandRepository, IMapper mapper)
    {
        _brandRepository = brandRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<BrandViewModel>> GetBrandsAsync()
    {
        var brands = await _brandRepository.GetAllAsync();
        return _mapper.Map<IEnumerable<BrandViewModel>>(brands);
    }
}