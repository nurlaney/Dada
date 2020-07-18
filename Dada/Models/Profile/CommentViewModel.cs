using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dada.Models.Profile
{
    public class CommentViewModel
    {
        public string Text { get; set; }
        public DateTime AddedDate { get; set; }
        public int UserId { get; set; }
        public UserViewModel User { get; set; }
        public int PostId { get; set; }
        public PostViewModel Post { get; set; }
    }
}
