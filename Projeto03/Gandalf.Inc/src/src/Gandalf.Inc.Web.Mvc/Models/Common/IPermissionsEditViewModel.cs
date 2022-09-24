using System.Collections.Generic;
using Gandalf.Inc.Roles.Dto;

namespace Gandalf.Inc.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}