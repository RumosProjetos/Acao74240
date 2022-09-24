using System.Collections.Generic;
using Gandalf.Inc.Roles.Dto;

namespace Gandalf.Inc.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
