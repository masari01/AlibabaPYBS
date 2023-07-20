using AlibabaPBYS.Core.Entities;
using AlibabaPBYS.Core.Interfaces.Repository;

namespace AlibabaPBYS.DataAccessLayer.Repository;

public class CarModelRepository : BaseRepository<CarModel>, ICarModelRepository
{
    public CarModelRepository(ApplicationDBContext dbContext) : base(dbContext)
    {
    }
}
