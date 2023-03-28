using System.Collections.Generic;
using DevExpViewer.Roles.Dto;

namespace DevExpViewer.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}