using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Identity.Models
{
    public class LoginViewModel
    {
        [EmailAddress]
        // [DisplayName("E-Posta")]
        // [Required(ErrorMessage = "Lütfen E-Posta alanını boş geçmeyiniz!")]
        public string Email { get; set; } = null!;

        [DataType(DataType.Password)]
        // [DisplayName("Parola")]
        // [Required(ErrorMessage = "Lütfen parolayı boş geçmeyiniz!")]
        public string Password { get; set; } = null!;
        // [DisplayName("Beni Hatırla")]
        public bool RememberMe { get; set; } = true;
    }
}