using AlibabaPBYS.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace AlibabaPBYS.DataAccessLayer;

/// <summary>
/// Database bağlantısını yönetecek, database işlemlerini yönetecek DbContext sınıfı.
/// </summary>
public class ApplicationDBContext : DbContext
{
    /// <summary>
    /// Bir opsiyon yani veritabanına bağlanmak ve işlemleri gerçekleştirmek için bir opsiyon.
    /// Bu opsiyonun tanımlamasını ve nasıl olması gerektiğini Program.cs sınıfında yazıyoruz.
    /// </summary>
    /// <param name="options"></param>
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
    {
    }
    /// <summary>
    /// EF Core'un DB tarafında hangi tabloların kod tarafında hangi sınıflar ile eşleşeceğini bilmesi için yapılan tanımlamalar.
    /// </summary>
    public DbSet<Car> Cars { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<CarModel> CarModels { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>()
            .HasOne(x => x.CarModel)
            .WithMany(x => x.Cars)
            .OnDelete(DeleteBehavior.NoAction);
        modelBuilder.Entity<Brand>()
            .HasData(new Brand[]
            {
                new Brand{Id=1, Name="Mercedes"},
                new Brand{Id=2,Name="Toyota"}
            });
        modelBuilder.Entity<CarModel>()
            .HasData(new CarModel[]
            {
                new CarModel{Id=1, Name="A180", BrandId=1},
                new CarModel{Id=2, Name="C200", BrandId=1},
                new CarModel{Id=3, Name="Corolla", BrandId=2},
                new CarModel{Id=4, Name="Auris", BrandId=2}

            });
        modelBuilder.Entity<Car>()
            .HasData(new Car[]
            {
                new Car{Id=1, BrandId = 1, CarModelId=1, Plate="01ABS01", ExaminationDuration=2, ExaminationDate=new DateTime(2023,08,10), NextExaminationDate=new DateTime(2025,08,10), CarType="Otomobil"},
                new Car{Id=2, BrandId = 1, CarModelId=2, Plate="01ABS01", ExaminationDuration=2, ExaminationDate=new DateTime(2023,08,10), NextExaminationDate=new DateTime(2025,08,10), CarType="Otomobil"},
                new Car{Id=3, BrandId = 2, CarModelId=3, Plate="01ABS01", ExaminationDuration=2, ExaminationDate=new DateTime(2023,08,10), NextExaminationDate=new DateTime(2025,08,10), CarType="Otomobil"},
                new Car{Id=4, BrandId = 2, CarModelId=4, Plate="01ABS01", ExaminationDuration=2, ExaminationDate=new DateTime(2023,08,10), NextExaminationDate=new DateTime(2025,08,10), CarType="Otomobil"}
            });
        base.OnModelCreating(modelBuilder);
    }
}