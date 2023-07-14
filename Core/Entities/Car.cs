namespace AlibabaPBYS.Core.Entities;

//Araç Muayene Takibi için oluşturulmuş gerekli ve yeterli olan başlıca özelliklerin tanımlandığı Araç entity sınıfı.
public class Car
{
    public int Id { get; set; }
    public string Plate { get; set; }//Plaka
    public int ExaminationDuration { get; set; }//Muayene Süresi
    public DateTime ExaminationDate { get; set; }//Muayene Tarihi
    public DateTime NextExaminationDate { get; set; }//Bir Sonraki Muayene Tarihi
    public string CarType { get; set; }//Araç Tipi
    public bool IsExaminated { get; set; }//Muayene Yapıldı Mı?
    public Brand Brand { get; set; }
    public CarModel CarModel { get; set; }
}
