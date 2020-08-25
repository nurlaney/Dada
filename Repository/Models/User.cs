using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
   public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime JoinDate { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public string ConectionId { get; set; }
        public string ConfirmToken { get; set; }
        public bool EmailConfirmed { get; set; }
        public ICollection<GroupUser> GroupUsers { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Notification> Notifications { get; set; }
        public UserData UserData { get; set; }
        public UserSocial UserSocial { get; set; }
    }
}
