using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DevExpViewer.EntityFrameworkCore;
using DevExpViewer.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace DevExpViewer.Web.Tests
{
    [DependsOn(
        typeof(DevExpViewerWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class DevExpViewerWebTestModule : AbpModule
    {
        public DevExpViewerWebTestModule(DevExpViewerEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DevExpViewerWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(DevExpViewerWebMvcModule).Assembly);
        }
    }
}