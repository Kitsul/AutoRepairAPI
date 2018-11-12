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
            CreateMap<Entities.User, ModelsDTO.UserDto>();
        }
    }
}
