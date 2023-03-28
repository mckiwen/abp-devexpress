using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DevExpViewer.Configuration;

namespace DevExpViewer.Web.Host.Startup
{
    [DependsOn(
       typeof(DevExpViewerWebCoreModule))]
    public class DevExpViewerWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public DevExpViewerWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DevExpViewerWebHostModule).GetAssembly());
        }
    }
}
