﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
   public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime AddedDate { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
        public ICollection<CommentReaction> CommentReactions { get; set; }
    }
}
