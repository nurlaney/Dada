using Dada.Models.Userdata;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dada.Models.Profile
{
    public class UserViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Adınızı daxil edin...")]
        [MaxLength(55, ErrorMessage = "maksimum 55 xarakter yaza bilərsən, bağışla")]
        [MinLength(4, ErrorMessage = "minimum 4 xarakter yazmalısan,dostum,bağışla")]
        public string FullName { get; set; }
        [RegularExpression(@"^[a-zA-Z''-']{1,40}$",
        ErrorMessage = "Dəstəklənməyən xarakter")]
        [Required(ErrorMessage = "İstifadəçi adınızı daxil edin...")]
        [MaxLength(55, ErrorMessage = "maksimum 55 xarakter yaza bilərsən, bağışla")]
        [MinLength(4, ErrorMessage = "minimum 4 xarakter yazmalısan,dostum,bağışla")]
        public string Username { get; set; }
        public string Token { get; set; }
        [Required(ErrorMessage = "E-mail daxil edin...")]
        [MaxLength(50, ErrorMessage = "Email maximum 50 xarakter ola bilər")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Duzgun email daxil edin")]
        public string ConfirmToken { get; set; }
        public bool EmailConfirmed { get; set; }
        public string Email { get; set; }
        public DateTime JoinDate { get; set; }
        public string ConectionId { get; set; }
        public ICollection<GroupUser> GroupUsers { get; set; }
        public ICollection<PostViewModel> Posts { get; set; }
        public ICollection<CommentViewModel> Comments { get; set; }
        public UserDataViewModel UserData { get; set; }
        public UserSocialViewModel UserSocial { get; set; }
    }
}
