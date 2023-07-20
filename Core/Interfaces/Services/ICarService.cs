using AlibabaPBYS.Core.Models;

namespace AlibabaPBYS.Core.Interfaces.Services;

public interface ICarService
{
    Task<CarViewModel> AddCar(CarAddViewModel model);
    Task<IEnumerable<CarViewModel>> GetAllCars();
    Task<CarViewModel> GetCarById(int Id);
    Task<CarViewModel> UpdateCar(CarUpdateViewModel model);
    Task DeleteCar(int Id);
}
