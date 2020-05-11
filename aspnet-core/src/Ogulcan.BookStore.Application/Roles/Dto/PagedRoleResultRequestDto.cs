using Abp.Application.Services.Dto;

namespace Ogulcan.BookStore.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

