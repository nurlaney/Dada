using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
   public class UserData
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string AboutMe { get; set; }
        public DateTime Birthday { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
