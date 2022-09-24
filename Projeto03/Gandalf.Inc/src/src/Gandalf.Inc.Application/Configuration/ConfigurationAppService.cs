using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Gandalf.Inc.Configuration.Dto;

namespace Gandalf.Inc.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : IncAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
