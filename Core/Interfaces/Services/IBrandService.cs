using AlibabaPBYS.Core.Models;

namespace AlibabaPBYS.Core.Interfaces.Services;

public interface IBrandService
{
    Task<IEnumerable<BrandViewModel>>  GetBrandsAsync();
}
