using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
   public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subtitle { get; set; }
        public string Info { get; set; }
        public string Rules { get; set; }
        public ICollection<GroupUser> GroupUsers { get; set; }
        public ICollection<Post> Posts { get; set; }

    }
}
