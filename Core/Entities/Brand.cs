namespace AlibabaPBYS.Core.Entities;

public class Brand
{
    public int Id { get; set; }
    public string Name { get; set; }

    public IEnumerable<CarModel> CarModels { get; set; }
}
