using System.Collections.Generic;
using Ogulcan.BookStore.Roles.Dto;

namespace Ogulcan.BookStore.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
