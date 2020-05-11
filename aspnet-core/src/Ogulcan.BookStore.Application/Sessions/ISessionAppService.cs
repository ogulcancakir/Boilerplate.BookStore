using System.Threading.Tasks;
using Abp.Application.Services;
using Ogulcan.BookStore.Sessions.Dto;

namespace Ogulcan.BookStore.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
