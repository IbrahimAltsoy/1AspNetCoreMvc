using Microsoft.AspNetCore.Mvc;

namespace _1AspNetCoreMvc.Controllers
{
    public class Mvc09ViewToControllerDataController : Controller
    {
        public IActionResult Index(string txtAra)
        {
            string test = "merhaba";
            ViewBag.GetVerisi=test;
            ViewBag.Deger = txtAra;
            // Burada txtAra değerini veritabanını yollayıp eşleşen kayıtları bulup gönderebiliriz.
            return View();
        }
        [HttpPost]
        public IActionResult Index(string text1, string ddlliste, bool cbonay, IFormCollection keyValuePairs)
        {
            //1.Yöntem parametrelerden gelen veiler
            ViewBag.text1= "TexBoxtan gelen Değer: "+ text1;
            ViewBag.ddlliste= "Dropdown dan gelen değer: "+ddlliste;
            ViewBag.cbonay= "Checkboxtan gelen değer: "+cbonay;
            //2.Yöntem Request.Form dan gelen veriler
            ViewBag.text2 = "TexBoxtan gelen Değer: " + Request.Form["text1"];
            ViewBag.ddlliste2 = "Dropdown dan gelen değer: " + Request.Form["ddlliste"]; 
            ViewBag.cbonay2 = "Checkboxtan gelen değer: " + Request.Form["cbonay"][0];
            //3.Yöntem IFormCollection ile gelen veriler
            ViewBag.text3 = "TexBoxtan gelen Değer: " + keyValuePairs["text1"];
            ViewBag.ddlliste3 = "Dropdown dan gelen değer: " + keyValuePairs["ddlliste"];
            ViewBag.cbonay3 = "Checkboxtan gelen değer: " + keyValuePairs["cbonay"][0];

            return View();
        }
    }
}
