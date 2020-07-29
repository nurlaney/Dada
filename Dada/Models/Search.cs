using Dada.Models.Account;
using Dada.Models.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dada.Models
{
    public class Search
    {
        public List<string> Nicks { get; set; }
        public List<string> Clubs { get; set; }
        public List<string> Titles { get; set; }
    }
}
