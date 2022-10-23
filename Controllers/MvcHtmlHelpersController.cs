using Microsoft.AspNetCore.Mvc;

namespace _1AspNetCoreMvc.Controllers
{
    public class MvcHtmlHelpersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
