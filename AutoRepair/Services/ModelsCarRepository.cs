using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoRepair.Context;
using AutoRepair.Entities;
using Microsoft.EntityFrameworkCore;

namespace AutoRepair.Services
{
    public class ModelsCarRepository : IModelsCarRepository
    {
        private AutoRepairContext _context;
        public ModelsCarRepository(AutoRepairContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<IEnumerable<ModelCar>> GetModelsCarAsync()
        {
            return await _context.ModelsCar.ToListAsync();
        }
        public async Task<ModelCar> GetModelCarAsync(string nameCar)
        {
            return await _context.ModelsCar.FirstOrDefaultAsync(car => car.Name.Equals(nameCar));
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
            }
        }
    }
}
