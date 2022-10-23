using Microsoft.AspNetCore.Mvc;

namespace _1AspNetCoreMvc.Controllers
{
    public class MvcRazorSyntaxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
