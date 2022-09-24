using Abp.Application.Services;
using Gandalf.Inc.MultiTenancy.Dto;

namespace Gandalf.Inc.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

