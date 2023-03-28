using Abp.Application.Services.Dto;

namespace DevExpViewer.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

