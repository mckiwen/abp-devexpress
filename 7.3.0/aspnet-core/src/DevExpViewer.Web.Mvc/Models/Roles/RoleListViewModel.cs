using System.Collections.Generic;
using DevExpViewer.Roles.Dto;

namespace DevExpViewer.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
