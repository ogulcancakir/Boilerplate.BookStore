using System.Collections.Generic;
using Ogulcan.BookStore.Roles.Dto;

namespace Ogulcan.BookStore.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}