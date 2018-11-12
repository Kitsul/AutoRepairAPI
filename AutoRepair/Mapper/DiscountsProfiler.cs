using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
