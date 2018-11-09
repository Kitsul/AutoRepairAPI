using AutoRepair.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoRepair.Services
{
    public interface IServicesTypeRepository
    {
        Task<IEnumerable<ServiceType>> GetServicesTypeAsync();
    }
}
