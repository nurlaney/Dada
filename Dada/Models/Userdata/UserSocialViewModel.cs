using Dada.Models.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dada.Models.Userdata
{
    public class UserSocialViewModel
    {
        public string FbLink { get; set; }
        public string TwitLink { get; set; }
        public string InstaLink { get; set; }
        public string GoogleLink { get; set; }
        public string PatreonLink { get; set; }
        public string DiscordLink { get; set; }
        public string YoutubeLink { get; set; }
        public string TwitchLink { get; set; }

        public int UserId { get; set; }

        public UserViewModel User { get; set; }
    }
}
