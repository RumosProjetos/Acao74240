using System.Collections.Generic;
using Gandalf.Inc.Roles.Dto;

namespace Gandalf.Inc.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
