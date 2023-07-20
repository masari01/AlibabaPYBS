using AlibabaPBYS.Core.Entities;
using AlibabaPBYS.Core.Interfaces.Repository;
using AlibabaPBYS.Core.Interfaces.Services;
using AlibabaPBYS.Core.Models;
using AutoMapper;

namespace AlibabaPBYS.BusinessLayer.Services;

public class CarService : ICarService
{
    private readonly ICarRepository _carRepository;
    private readonly IMapper _mapper;
    public CarService(ICarRepository carRepository, IMapper mapper)
    {
        _carRepository = carRepository;
        _mapper = mapper;
    }

    public async Task<CarViewModel> AddCar(CarAddViewModel model)
    {
        var carToAdd = _mapper.Map<Car>(model);
        var addedCar = await _carRepository.AddAsync(carToAdd);
        return _mapper.Map<CarViewModel>(addedCar);        
    }

    public Task DeleteCar(int Id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CarViewModel>> GetAllCars()
    {
        throw new NotImplementedException();
    }

    public Task<CarViewModel> GetCarById(int Id)
    {
        throw new NotImplementedException();
    }

    public Task<CarViewModel> UpdateCar(CarUpdateViewModel model)
    {
        throw new NotImplementedException();
    }
}
