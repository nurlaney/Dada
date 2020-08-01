using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
   public class UserSocial
    {
        public int Id { get; set; }
        public string FbLink { get; set; }
        public string TwitLink { get; set; }
        public string InstaLink { get; set; }
        public string GoogleLink { get; set; }
        public string PatreonLink { get; set; }
        public string DiscordLink { get; set; }
        public string YoutubeLink { get; set; }
        public string TwitchLink { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
