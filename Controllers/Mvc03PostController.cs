using Microsoft.AspNetCore.Mvc;

namespace _1AspNetCoreMvc.Controllers
{
    public class Mvc03PostController : Controller
    {
        [HttpGet]
        public IActionResult Index() // Üstte herhangi bir metod belirtilmezse default olarak get metodu olmuş olur.
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string txtAd) // Bu action un türü posttur, Post atritubitü aşağıdaki action sadece post işlemi gerçekleştiğinde çalışır.
        {

            return View();
        }
    }
}
