using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Ogulcan.BookStore.Controllers;

namespace Ogulcan.BookStore.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : BookStoreControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
