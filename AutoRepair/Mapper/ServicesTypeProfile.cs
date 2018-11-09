using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoRepair.Mapper
{
    public class ServicesTypeProfile : Profile
    {
        public ServicesTypeProfile()
        {
            CreateMap<Entities.ServiceType, Models.ServiceType>()
                .ForMember(x => x.Name, y => y.MapFrom(src => src.Name));
        }
    }
}
