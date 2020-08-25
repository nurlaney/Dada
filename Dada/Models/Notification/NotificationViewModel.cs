using Dada.Models.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dada.Models.Notification
{
    public class NotificationViewModel
    {
        public string Text { get; set; }
        public bool IsRead { get; set; }
        public string Url { get; set; }
        public string SenderName { get; set; }
        public int UserId { get; set; }

        public UserViewModel User { get; set; }
    }
}
