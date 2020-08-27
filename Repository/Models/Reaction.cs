using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
  public  class Reaction
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public bool Upvote { get; set; }
        public DateTime AddedDate { get; set; }
        public User User { get; set; }
        public Post Post { get; set; }
    }
}
