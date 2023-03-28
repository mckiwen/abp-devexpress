using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace DevExpViewer.Web.Views
{
    public abstract class DevExpViewerRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected DevExpViewerRazorPage()
        {
            LocalizationSourceName = DevExpViewerConsts.LocalizationSourceName;
        }
    }
}
