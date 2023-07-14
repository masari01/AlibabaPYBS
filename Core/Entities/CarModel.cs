namespace AlibabaPBYS.Core.Entities;

// Araç Muayene Takibi için oluşturulmuş araçların modellerinin tanımlandığı Model entity sınıfı.
public class CarModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Brand Brand { get; set; }
    public IEnumerable<Car> Cars { get; set; }
}