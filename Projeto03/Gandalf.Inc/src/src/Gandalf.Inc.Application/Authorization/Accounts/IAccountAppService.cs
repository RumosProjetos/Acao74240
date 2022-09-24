using System.Threading.Tasks;
using Abp.Application.Services;
using Gandalf.Inc.Authorization.Accounts.Dto;

namespace Gandalf.Inc.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
