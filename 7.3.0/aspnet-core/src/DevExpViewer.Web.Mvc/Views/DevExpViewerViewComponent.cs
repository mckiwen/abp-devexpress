using Abp.AspNetCore.Mvc.ViewComponents;

namespace DevExpViewer.Web.Views
{
    public abstract class DevExpViewerViewComponent : AbpViewComponent
    {
        protected DevExpViewerViewComponent()
        {
            LocalizationSourceName = DevExpViewerConsts.LocalizationSourceName;
        }
    }
}
