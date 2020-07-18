using Dada.Models.Account;
using Dada.Models.Profile;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dada.Models
{
    public class MainViewModel
    {
        public ICollection<PostViewModel> Posts { get; set; }
        public GroupUser GroupUsers { get; set; }
        public ICollection<GroupViewModel> Groups { get; set; }
        public ICollection<UserViewModel> Users { get; set; }
    }
}
