using _1AspNetCoreMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace _1AspNetCoreMvc.Controllers
{
    public class ModelValidationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UyeListesi()
        {
            var uyelistesi = new List<Uye>()
            {
                new Uye()
                {
                    Id=18,
                    Name="ibrahim",
                    Surname="Altsoy",
                    Email="i@gmail.com",

                },
                new Uye()
                {
                    Id=5,
                    Name="Erkan",
                    Surname="İşbilir",
                    Email="Erkan@gmail.com",

                },new Uye()
                {
                    Id=8,
                    Name="Nurdan",
                    Surname="Cengiz",
                    Email="nurdan@gmail.com",

                }

            };
            uyelistesi.Add(new Uye() { Id = 6, Name = "Ersin", Surname = "Yılmaz", Email = "ersin@gmail.com" });
            return View(uyelistesi);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Uye uye)
        {
            if (ModelState.IsValid)
            {
                // içeri girer bakar eğer uye boş değilse kayıt işlemi yaptırırız 
            }
            if(!ModelState.IsValid)
            {
                // eğer uye geçersiz ise 
                ModelState.AddModelError("", "Lütfen zorunlu alanları doldurunuz");
            }
           
            return View(uye);
        }
        public IActionResult Edit(int id)
        {
            var model = new Uye() { Id = 6, Name = "Ersin", Surname = "Yılmaz", Email = "ersin@gmail.com" };
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(Uye uye, int id)
        {
            if (ModelState.IsValid)
            {
                // içeri girer bakar eğer uye boş değilse güncelleme işlemi yaptırırız 
            }
            if (!ModelState.IsValid)
            {
                // eğer uye geçersiz ise 
                ModelState.AddModelError("", "Lütfen zorunlu alanları doldurunuz");
            }
           
            return View(uye);
        }
        public IActionResult Delete(int id)
        {
            var model = new Uye() { Id = 6, Name = "Ersin", Surname = "Yılmaz", Email = "ersin@gmail.com" };
            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(Uye uye, int id)
        {
            if (ModelState.IsValid)
            {
                // içeri girer bakar eğer uye boş değilse silme işlemi yaptırırız 
            }
            if (!ModelState.IsValid)
            {
                // eğer uye geçersiz ise 
                ModelState.AddModelError("", "Lütfen zorunlu alanları doldurunuz");
            }

            return View(uye);
        }
    }
}
