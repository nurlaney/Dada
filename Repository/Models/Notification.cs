using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repository.Models
{
   public class Notification
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsRead { get; set; }
        public DateTime SendDate { get; set; }
        public string Url { get; set; }
        public string SenderName { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }
    }
}
