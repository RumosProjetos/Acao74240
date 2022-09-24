using Abp.AutoMapper;
using Gandalf.Inc.Roles.Dto;
using Gandalf.Inc.Web.Models.Common;

namespace Gandalf.Inc.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
