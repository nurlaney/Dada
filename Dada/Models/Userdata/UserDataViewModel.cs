using Dada.Models.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dada.Models.Userdata
{
    public class UserDataViewModel
    {
        public string City { get; set; }
        public string AboutMe { get; set; }
        public DateTime Birthday { get; set; }

        public int UserId { get; set; }

        public UserViewModel User { get; set; }
    }
}
