using AlibabaPBYS.Core.Models;

namespace AlibabaPBYS.Core.Interfaces.Services;

public interface ICarModelService
{
    Task<IEnumerable<CarModelViewModel>> GetCarModelsAsync();
}
