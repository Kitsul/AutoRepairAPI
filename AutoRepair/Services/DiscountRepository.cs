using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoRepair.Context;
using AutoRepair.Entities;
using Microsoft.EntityFrameworkCore;

namespace AutoRepair.Services
{
    public class DiscountRepository : IDiscountRepository
    {
        private AutoRepairContext _context;
        public DiscountRepository(AutoRepairContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Discount>> GetDiscountAsync()
        {
            return await _context.Discounts.Include(x => x.UserDiscount).ToListAsync();
        }
    }
}
