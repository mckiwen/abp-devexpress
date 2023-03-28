using System.Threading.Tasks;
using Abp.Application.Services;
using DevExpViewer.Sessions.Dto;

namespace DevExpViewer.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
