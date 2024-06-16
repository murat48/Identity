using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Identity.Models
{

    public class UserViewModel
    {
        public string? Id { get; set; } = string.Empty;

        [Required]
        [DisplayName("Kullanıcı Adı")]
        public string UserName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [DisplayName("E-Posta")]

        public string Email { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Parola")]
        public string Password { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Parola eşleşmiyor.")]
        [DisplayName("Tekrar Parola")]
        public string ConfirmPassword { get; set; } = string.Empty;

    }
}