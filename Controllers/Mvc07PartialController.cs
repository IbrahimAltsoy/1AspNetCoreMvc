using Microsoft.AspNetCore.Mvc;

namespace _1AspNetCoreMvc.Controllers
{
    public class Mvc07PartialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
