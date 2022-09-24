using Abp.Authorization;
using Gandalf.Inc.Authorization.Roles;
using Gandalf.Inc.Authorization.Users;

namespace Gandalf.Inc.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
