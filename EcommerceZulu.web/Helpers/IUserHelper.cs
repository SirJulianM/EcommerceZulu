using EcommerceZulu.web.Data.DataEntities;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace EcommerceZulu.web.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

        Task CheckRoleAsync(string roleName);

        Task AddUserToRoleAsync(User user, string roleName);

        Task<bool> IsUserInRoleAsync(User user, string roleName);

    }
}
