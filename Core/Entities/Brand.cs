namespace AlibabaPBYS.Core.Entities;

// Araç Muayene Takibi için oluşturulmuş araçların markalarının tanımlandığı Marka entity sınıfı.
public class Brand
{
    public int Id { get; set; }
    public string Name { get; set; }//Araç Marka İsimleri

    public IEnumerable<CarModel> CarModels { get; set; }
}