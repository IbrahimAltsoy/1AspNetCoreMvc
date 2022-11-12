using Microsoft.AspNetCore.Mvc;

namespace _1AspNetCoreMvc.Controllers
{
    public class Mvc08ControllerToViewController : Controller
    {
        public IActionResult Index()
        {// 3 temel yöntemle veri gönderebiliyoruz. 
            // 1-ViewBag: Tek kullanımlık ömrü vardır.
            ViewBag.UrunKAtegori = "Bilgisayar";
            // 2-ViewData: Tek kullanımlık ömrü var 
            ViewData["UrunAdi"] = "Laptop";
            // 3-TempData 2 kullanımlık ömrü var 
            TempData["UrunFiyat"] = 18000;
            return View();
        }
    }
}
