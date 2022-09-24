using System.Threading.Tasks;
using Abp.Application.Services;
using Gandalf.Inc.Sessions.Dto;

namespace Gandalf.Inc.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
