using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoRepair.Context;
using AutoRepair.Entities;
using Microsoft.EntityFrameworkCore;

namespace AutoRepair.Services
{
    public class AppoimtmentsRepository : IAppoimtmentsRepository, IDisposable
    {
        private AutoRepairContext _context;
        public AppoimtmentsRepository(AutoRepairContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void AddAppoimtment(Appoimtment appoimtment)
        {
            if(appoimtment == null)
            {
                throw new ArgumentException(nameof(appoimtment));
            }
            _context.Add(appoimtment);
        }
        public async Task<bool> SaveChangesAsync()
        {
            // return true if 1 or more entities were changed
            return (await _context.SaveChangesAsync() > 0);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }



        protected virtual void Dispose(bool disposing)
        {
            if(disposing)
            {
                if(_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
            }
        }

    }
}
