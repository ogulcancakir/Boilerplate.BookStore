using System.Threading.Tasks;
using Ogulcan.BookStore.Configuration.Dto;

namespace Ogulcan.BookStore.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
