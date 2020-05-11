using System.Threading.Tasks;
using Abp.Application.Services;
using Ogulcan.BookStore.Authorization.Accounts.Dto;

namespace Ogulcan.BookStore.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
