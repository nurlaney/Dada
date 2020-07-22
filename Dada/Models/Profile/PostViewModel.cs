using Dada.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dada.Models.Profile
{
    public class PostViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime AddedDate { get; set; }
        public int UserId { get; set; }
        public int? GroupId { get; set; }
        public UserViewModel User { get; set; }
        public GroupViewModel Group { get; set; }
        public ICollection<CommentViewModel> Comments { get; set; }
        public CommentViewModel Comment { get; set; }
    }
}
