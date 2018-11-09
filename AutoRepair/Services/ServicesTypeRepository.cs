using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoRepair.Context;
using AutoRepair.Entities;
using Microsoft.EntityFrameworkCore;

namespace AutoRepair.Services
{
    public class ServicesTypeRepository : IServicesTypeRepository
    {
        private AppoimtmentsContext _context;
        public ServicesTypeRepository(AppoimtmentsContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<IEnumerable<ServiceType>> GetServicesTypeAsync()
        {
            return await _context.ServicesType.ToListAsync();
        }
    }
}
