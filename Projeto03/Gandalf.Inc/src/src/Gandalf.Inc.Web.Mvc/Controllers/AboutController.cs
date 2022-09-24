using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Gandalf.Inc.Controllers;

namespace Gandalf.Inc.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : IncControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
