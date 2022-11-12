using _1AspNetCoreMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace _1AspNetCoreMvc.Controllers
{
    public class Mvc10ModelBindingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult KullaniciSayfasi()
        {

            Kullanici kullanici = new Kullanici()
            {
                Id = 1,
                Ad = "Ibrahim",
                Soyad = "Altsoy",
                Email = "i.@gmail.com",
                KulaniciAdi = "Altsoy",
                Sifre = "1234"
            };


            return View(kullanici);
        }
        [HttpPost]
        public IActionResult KullaniciSayfasi(Kullanici kullanici)// Ekrandan modelle gönderilen kullanıcı nesnesini bu şekilde action metoduna parametre ekleyerek yakalabiliriz.
        {
            return View(kullanici);
        }
        public IActionResult AdresSayfasi()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AdresSayfasi(Adres adres)
        {
            return View(adres);
        }
        public IActionResult UyeSayfasi()

        {
            Kullanici kullanici = new Kullanici()
            {
                Id = 1,
                Ad = "Ibrahim",
                Soyad = "Altsoy",
                Email = "i.@gmail.com",
                KulaniciAdi = "Altsoy",
                Sifre = "1234"
            };
            var model = new UyeSayfasiModelView()
            {
                Kullanici = kullanici,
                Adres = new Adres 
                { 
                    Id= 2,
                    Sehir="Ankara",
                    Ilce="Çankaya",
                    AcikAdres="Ayrancı"
                }
                
            };
            return View(model);
        }
    }
}
