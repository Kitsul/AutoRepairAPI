using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoRepair.Mapper
{
    public class UserProfiler : Profile
    {
        public UserProfiler()
        {
            CreateMap<Entities.User, Models.User>()
               .ForMember(x => x.FullName,
                map => map.MapFrom(src => $"{ src.FirstName} { src.SecondName}"));
        }
    }
}
