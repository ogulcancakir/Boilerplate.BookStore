using System.Collections.Generic;
using Ogulcan.BookStore.Roles.Dto;

namespace Ogulcan.BookStore.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
