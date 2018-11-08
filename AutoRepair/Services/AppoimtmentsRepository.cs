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
        private AppoimtmentsContext _context;
        public AppoimtmentsRepository(AppoimtmentsContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public Task<Appoimtment> AddAppoimtmentAsync(Appoimtment appoimtment)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Appoimtment>> GetAppoimtmentsAsync()
        {
            return  await _context.Appoimtments.ToListAsync();
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
