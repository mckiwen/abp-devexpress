using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace DevExpViewer.Controllers
{
    public abstract class DevExpViewerControllerBase: AbpController
    {
        protected DevExpViewerControllerBase()
        {
            LocalizationSourceName = DevExpViewerConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
