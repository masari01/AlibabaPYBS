using AlibabaPBYS.Core.Interfaces.Repository;
using AlibabaPBYS.Core.Interfaces.Services;
using AlibabaPBYS.Core.Models;
using AutoMapper;

namespace AlibabaPBYS.BusinessLayer.Services;

public class CarModelService : ICarModelService
{
    private readonly ICarModelRepository _carModelRepository;
    private readonly IMapper _mapper;

    public CarModelService(ICarModelRepository carModelRepository, IMapper mapper)
    {
        _carModelRepository = carModelRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<CarModelViewModel>> GetCarModelsAsync()
    {
        var carModels = await _carModelRepository.GetAllAsync();
        return _mapper.Map<IEnumerable<CarModelViewModel>>(carModels);
    }
}
