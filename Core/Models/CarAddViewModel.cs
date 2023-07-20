namespace AlibabaPBYS.Core.Models;

public class CarAddViewModel
{   
    public string Plate { get; set; }
    public  int BrandId { get; set; }
    public int CarModelId { get; set; }
    public int ExaminationDuration { get; set; }
    public DateTime ExaminationDate { get; set; }
    public DateTime NextExaminationDate { get; set; }
    public string CarType { get; set; }
    public bool IsExaminated { get; set; }
}
