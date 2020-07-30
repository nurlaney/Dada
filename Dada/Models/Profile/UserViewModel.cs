using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dada.Models.Profile
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; } 
        public string Username { get; set; }
        public string AboutMe { get; set; }
        public string Token { get; set; }
        public ICollection<GroupUser> GroupUsers { get; set; }
        public ICollection<PostViewModel> Posts { get; set; }
        public ICollection<CommentViewModel> Comments { get; set; }
    }
}
