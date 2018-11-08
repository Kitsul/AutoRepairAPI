using AutoRepair.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoRepair.Services
{
    public interface IAppoimtmentsRepository
    {
        Task<Appoimtment> AddAppoimtmentAsync(Appoimtment appoimtment);
        Task<IEnumerable<Appoimtment>> GetAppoimtmentsAsync();
    }
}
