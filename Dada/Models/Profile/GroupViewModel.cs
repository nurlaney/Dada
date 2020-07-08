using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dada.Models.Account
{
    public class GroupViewModel
    {
        public string Name { get; set; }
        public string Info { get; set; }
        public string Rules { get; set; }
        public ICollection<GroupUser> GroupUsers { get; set; }
    }
}
