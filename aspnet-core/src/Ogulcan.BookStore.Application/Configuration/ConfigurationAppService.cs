using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Ogulcan.BookStore.Configuration.Dto;

namespace Ogulcan.BookStore.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : BookStoreAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
