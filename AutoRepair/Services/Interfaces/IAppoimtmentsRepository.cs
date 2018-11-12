using AutoRepair.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoRepair.Services
{
    public interface IAppoimtmentsRepository
    {
        void AddAppoimtment(Appoimtment appoimtment);
        Task<bool> SaveChangesAsync();
    }
}
