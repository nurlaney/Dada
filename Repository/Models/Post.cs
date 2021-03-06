﻿using System;
using System.Collections.Generic;

namespace Repository.Models
{
   public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime AddedDate { get; set; }
        public int UserId { get; set; }
        public int? GroupId { get; set; }
        public User User { get; set; }
        public Group Group { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Reaction> Reactions { get; set; }
    }
}
