using System.Threading.Tasks;
using Gandalf.Inc.Configuration.Dto;

namespace Gandalf.Inc.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
