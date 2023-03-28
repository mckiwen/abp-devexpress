using System.Threading.Tasks;
using DevExpViewer.Configuration.Dto;

namespace DevExpViewer.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
