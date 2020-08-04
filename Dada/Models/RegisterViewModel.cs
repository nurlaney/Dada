using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dada.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Adınızı daxil edin...")]
        [MaxLength(55,ErrorMessage ="maksimum 55 xarakter yaza bilərsən, bağışla")]
        [MinLength(4,ErrorMessage ="minimum 4 xarakter yazmalısan,dostum,bağışla")]
        public string FullName { get; set; }
        [RegularExpression(@"^[a-zA-Z''-']{1,40}$",
        ErrorMessage = "Dəstəklənməyən xarakter")]
        [Required(ErrorMessage = "İstifadəçi adınızı daxil edin...")]
        [MaxLength(55, ErrorMessage = "maksimum 55 xarakter yaza bilərsən, bağışla")]
        [MinLength(4, ErrorMessage = "minimum 4 xarakter yazmalısan,dostum,bağışla")]
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
