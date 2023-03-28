using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using DevExpViewer.Controllers;

namespace DevExpViewer.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : DevExpViewerControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
