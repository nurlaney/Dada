﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
   public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public string AboutMe { get; set; }
        public ICollection<GroupUser> GroupUsers { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
