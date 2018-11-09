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
        private AutoRepairContext _context;
        public ServicesTypeRepository(AutoRepairContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<IEnumerable<ServiceType>> GetServicesTypeAsync()
        {
            try
            {
                return await _context.ServicesType.ToListAsync();
            }
            catch(Exception ex)
            {
                var t = ex;
                return null;
            }
        }
    }
}
