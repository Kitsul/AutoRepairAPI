using AutoMapper;

namespace AutoRepair.Mapper
{
    public class DiscountsProfiler : Profile
    {
        public DiscountsProfiler()
        {
            CreateMap<Entities.Discount, ModelsDTO.DiscountDto>()
                .ForMember(x => x.DiscountMessage, 
                 map => map.MapFrom(src => $"Your discount is { src.Count } % { src.Description }"));
        }
    }
}
