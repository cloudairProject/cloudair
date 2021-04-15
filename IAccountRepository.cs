using CloudAirBD.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace cloudair.Models
{
    public interface IAccountRepository
    {
        Task<IdentityResult> CreateUserAsync(User user);
    }
}