using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
   public class GroupUser
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int GroupId { get; set; }
        public int? RoleId { get; set; }
        public User User { get; set; }
        public Group Group { get; set; }
        public Role Role { get; set; }
    }
}
