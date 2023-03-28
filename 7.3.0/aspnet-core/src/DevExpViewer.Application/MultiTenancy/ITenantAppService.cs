using Abp.Application.Services;
using DevExpViewer.MultiTenancy.Dto;

namespace DevExpViewer.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

