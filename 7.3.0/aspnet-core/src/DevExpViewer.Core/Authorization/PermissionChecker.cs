using Abp.Authorization;
using DevExpViewer.Authorization.Roles;
using DevExpViewer.Authorization.Users;

namespace DevExpViewer.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
