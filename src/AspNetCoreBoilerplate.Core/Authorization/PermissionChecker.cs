using Abp.Authorization;
using AspNetCoreBoilerplate.Authorization.Roles;
using AspNetCoreBoilerplate.Authorization.Users;

namespace AspNetCoreBoilerplate.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
