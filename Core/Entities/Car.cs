namespace AlibabaPBYS.Core.Entities;

public class Car
{
    public int Id { get; set; }
    public string Plate { get; set; }
    public int ExaminationDuration { get; set; }
    public int CarModelId { get; set; }
    public int BrandId { get; set; }
    public DateTime ExaminationDate { get; set; }
    public DateTime NextExaminationDate { get; set; }
    public string CarType { get; set; }
    public bool IsExaminated { get; set; }
    public Brand Brand { get; set; }
    public CarModel CarModel { get; set; }
}
