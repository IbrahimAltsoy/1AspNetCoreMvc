using System.ComponentModel.DataAnnotations;

namespace _1AspNetCoreMvc.Models
{
    public class Uye
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="bu alan Boş geçilemez"),StringLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "bu alan Boş geçilemez"), StringLength(50)]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez"), StringLength(50)]
        [EmailAddress(ErrorMessage ="Geçerisz Email")]
        public string Email { get; set; }
        
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Tc alanı boş geçilemez"), StringLength(11)]
        [Display(Name ="Tc Kimlik No")]
        [MinLength(11,ErrorMessage ="{0} 11 karakter olmalıdır")]
        [MaxLength(11, ErrorMessage = "{0} 11 karakter olmalıdır")]
        public string TcNo { get; set; }
        public DateTime DogumTarihi { get; set; }   
        public string UserName { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez"), StringLength(50)]
        [Display(Name = "şifreyi giriniz"), DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez"), StringLength(50)]
        [Display(Name = "Şifreyi Giriniz"), DataType(DataType.Password)]
        [Compare("Password")]
        public string PasswordRepeat { get; set; }   
        
    }
}
