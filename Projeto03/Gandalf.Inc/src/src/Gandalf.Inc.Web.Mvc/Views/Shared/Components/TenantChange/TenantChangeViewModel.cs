using Abp.AutoMapper;
using Gandalf.Inc.Sessions.Dto;

namespace Gandalf.Inc.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
