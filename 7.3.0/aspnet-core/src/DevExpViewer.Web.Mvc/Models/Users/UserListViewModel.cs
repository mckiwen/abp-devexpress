using System.Collections.Generic;
using DevExpViewer.Roles.Dto;

namespace DevExpViewer.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
