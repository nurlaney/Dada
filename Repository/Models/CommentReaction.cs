using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
   public class CommentReaction
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CommentId { get; set; }
        public bool Upvote { get; set; }
        public DateTime AddedDate { get; set; }
        public User User { get; set; }
        public Comment Comment { get; set; }
    }
}
