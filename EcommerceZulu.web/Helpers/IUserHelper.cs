using EcommerceZulu.Common.Enums;
using EcommerceZulu.web.Data.DataEntities;
using EcommerceZulu.web.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;

namespace EcommerceZulu.web.Helpers
{
    public interface IUserHelper
    {
        #region "Hola"

        #endregion

        #region "Hola1"

        #endregion

        #region "Hola2"

        #endregion
        Task<User> GetUserAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

        Task CheckRoleAsync(string roleName);

        Task AddUserToRoleAsync(User user, string roleName);

        Task<bool> IsUserInRoleAsync(User user, string roleName);

        Task<SignInResult> LoginAsync(LoginViewModel model);

        Task LogoutAsync();

        Task<SignInResult> ValidatePasswordAsync(User user, string password);

        Task<User> AddUserAsync(AddUserViewModel model, Guid imageId, UserType userType);

        Task<IdentityResult> ChangePasswordAsync(User user, string oldPassword, string newPassword);

        Task<IdentityResult> UpdateUserAsync(User user);

        Task<User> GetUserAsync(Guid userId);

        Task<string> GenerateEmailConfirmationTokenAsync(User user);

        Task<IdentityResult> ConfirmEmailAsync(User user, string token);

        Task<string> GeneratePasswordResetTokenAsync(User user);

        Task<IdentityResult> ResetPasswordAsync(User user, string token, string password);

    }
}
