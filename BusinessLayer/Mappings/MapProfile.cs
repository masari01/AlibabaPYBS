using AlibabaPBYS.Core.Entities;
using AlibabaPBYS.Core.Models;
using AutoMapper;

namespace AlibabaPBYS.BusinessLayer.Mappings;

public class MapProfile : Profile
{
    public MapProfile()
    {
        CreateMap<Car, CarAddViewModel>().ReverseMap();
        CreateMap<Brand, BrandViewModel>().ReverseMap();
        CreateMap<CarModel, CarModelViewModel>().ReverseMap();
        CreateMap<Car, CarViewModel>().ReverseMap();
    }
}