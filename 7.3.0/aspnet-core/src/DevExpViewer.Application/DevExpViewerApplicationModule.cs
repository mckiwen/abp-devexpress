using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DevExpViewer.Authorization;

namespace DevExpViewer
{
    [DependsOn(
        typeof(DevExpViewerCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class DevExpViewerApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<DevExpViewerAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(DevExpViewerApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
