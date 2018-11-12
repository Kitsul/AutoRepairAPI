using AutoRepair.Entities;
using System.Threading.Tasks;

namespace AutoRepair.Services
{
    public interface IUserRepository
    {
        Task<User> GetUserAsync(string email);
    }
}
