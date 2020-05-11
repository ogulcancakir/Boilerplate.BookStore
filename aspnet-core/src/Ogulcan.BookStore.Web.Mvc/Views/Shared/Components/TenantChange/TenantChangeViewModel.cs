using Abp.AutoMapper;
using Ogulcan.BookStore.Sessions.Dto;

namespace Ogulcan.BookStore.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
