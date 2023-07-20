using AlibabaPBYS.Core.Entities;
using AlibabaPBYS.Core.Interfaces.Repository;

namespace AlibabaPBYS.DataAccessLayer.Repository;

public class CarRepository : BaseRepository<Car>, ICarRepository
{
    public CarRepository(ApplicationDBContext dbContext) : base(dbContext)
    {
    }
}
