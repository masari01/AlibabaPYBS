using AlibabaPBYS.Core.Entities;
using AlibabaPBYS.Core.Interfaces.Repository;

namespace AlibabaPBYS.DataAccessLayer.Repository;

public class BrandRepository : BaseRepository<Brand>, IBrandRepository
{
    public BrandRepository(ApplicationDBContext dbContext) : base(dbContext)
    {
    }
}
