using System.Threading.Tasks;
using Abp.Application.Services;
using DevExpViewer.Authorization.Accounts.Dto;

namespace DevExpViewer.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
