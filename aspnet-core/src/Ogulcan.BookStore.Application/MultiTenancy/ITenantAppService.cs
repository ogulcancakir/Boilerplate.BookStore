using Abp.Application.Services;
using Ogulcan.BookStore.MultiTenancy.Dto;

namespace Ogulcan.BookStore.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

