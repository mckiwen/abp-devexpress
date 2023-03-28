using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using DevExpViewer.Configuration.Dto;

namespace DevExpViewer.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : DevExpViewerAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
