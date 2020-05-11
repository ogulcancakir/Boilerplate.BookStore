using Abp.AutoMapper;
using Ogulcan.BookStore.Roles.Dto;
using Ogulcan.BookStore.Web.Models.Common;

namespace Ogulcan.BookStore.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
