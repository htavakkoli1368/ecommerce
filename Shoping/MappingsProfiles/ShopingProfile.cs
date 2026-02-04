using AutoMapper;
using Shoping.Models.Domain;
using Shoping.Models.DTOs;

namespace Shoping.MappingsProfiles
{
    public class ShopingProfile : Profile
    {
        public ShopingProfile()
        {
            //Entity -> DTO

            CreateMap<RegionModel, RegionsDTOModel>().ReverseMap();
            CreateMap<DifficultyModel, DifficultyDTOModel>().ReverseMap();
            CreateMap<WalkModel, WalkDTOModel>().ReverseMap();
                
        }
    }
}
