using FluentValidation; // fluent Validation kütüphanesi ile class validationına yapmak için kullılan kütüphanedir. 

namespace _1AspNetCoreMvc.Models
{
    public class KullaniciValidator : AbstractValidator<Kullanici>
    {// Fluent Validation dan gelen AbstractValidator sınıfına kontrol edeceğimiz classı bu şekilde yapıyoruz. 

        public KullaniciValidator() 
        {
            RuleFor(x => x.Ad).NotNull();           
            RuleFor(x => x.Soyad).NotEmpty().WithMessage("Soyad boş geçilemez");
            RuleFor(x => x.Email).EmailAddress().NotNull().WithMessage("Email boş geçilemez");
            RuleFor(x => x.KulaniciAdi).NotEmpty();
            RuleFor(x => x.Sifre).NotNull().WithMessage("Şifre boş geçilemez").Length(3,20);




        }


    }
}
