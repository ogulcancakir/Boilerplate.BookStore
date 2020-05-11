using Abp.Authorization;
using Ogulcan.BookStore.Authorization.Roles;
using Ogulcan.BookStore.Authorization.Users;

namespace Ogulcan.BookStore.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
