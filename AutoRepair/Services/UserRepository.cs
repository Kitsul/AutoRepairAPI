using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoRepair.Context;
using AutoRepair.Entities;
using Microsoft.EntityFrameworkCore;

namespace AutoRepair.Services
{
    public class UserRepository : IUserRepository
    {
        private AutoRepairContext _context;

        public UserRepository(AutoRepairContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<User> GetUserAsync(string email)
        {
            return await _context.Users.Include(c => c.ModelsCar)
                                       .Include(udc => udc.UserDiscountServices)
                                       .FirstOrDefaultAsync(u => u.Email.Equals(email));
        }

        public Task SaveUserAsync()
        {
            throw new NotImplementedException();
        }
    }
}
