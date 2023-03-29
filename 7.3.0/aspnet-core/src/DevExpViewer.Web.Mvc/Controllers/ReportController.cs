using Abp.AspNetCore.Mvc.Authorization;
using DevExpViewer.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace DevExpViewer.Web.Controllers
{
    [AbpMvcAuthorize]
    public class ReportController : DevExpViewerControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
