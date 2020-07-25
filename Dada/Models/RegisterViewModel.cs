using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dada.Models
{
    public class RegisterViewModel
    {
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",
        ErrorMessage = "Dəstəklənməyən xarakter")]
        [Required(ErrorMessage = "Adınızı daxil edin...")]
        public string FullName { get; set; }
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",
        ErrorMessage = "Dəstəklənməyən xarakter")]
        [Required(ErrorMessage = "İstifadəçi adınızı daxil edin...")]
        public string Username { get; set; }
        [Required(ErrorMessage = "E-mail daxil edin...")]
        [MaxLength(50, ErrorMessage = "Email maximum 50 xarakter ola bilər")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Duzgun email daxil edin")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifrənizi daxil edin...")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword", ErrorMessage = "Şifrə və şifrə təsdiqi eyni olmalıdır")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Şifrənizi təsdiqləyin")]
        public string ConfirmPassword { get; set; }
    }
}
