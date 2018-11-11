using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoRepair.Mapper
{
    public class ModelsCarProfile : Profile
    {
        public ModelsCarProfile()
        {
            CreateMap<Entities.ModelCar, Models.ModelCar>()
                .ForMember(x => x.Name, map => map.MapFrom(src => src.Name));
        }
    }
}
