using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Ogulcan.BookStore.Controllers;

namespace Ogulcan.BookStore.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : BookStoreControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
