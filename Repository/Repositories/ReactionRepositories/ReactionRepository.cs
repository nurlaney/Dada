using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.ReactionRepositories
{
    public class ReactionRepository : IReactionRepository
    {
        private readonly DadaDbContext _context;
        public ReactionRepository(DadaDbContext context)
        {
            _context = context;
        }
        public void AddReaction(Reaction reaction)
        {
            _context.Add(reaction);
            _context.SaveChanges();
        }

        public Reaction FindReaction(int userId, int postId)
        {
            return _context.Reactions.FirstOrDefault(r => r.UserId == userId && r.PostId == postId);
        }

        public Notification GetNotificationByReaction(string url, string sendername)
        {
            return _context.Notifications.FirstOrDefault(n => n.Url == url && n.SenderName == sendername);
        }

        public void RemoveNotify(Notification notification)
        {
            _context.Remove(notification);
            _context.SaveChanges();
        }

        public void RemoveReaction(Reaction reaction)
        {
            _context.Remove(reaction);
            _context.SaveChanges();
        }
    }
}
