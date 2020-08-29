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

        public void AddCommentReaction(CommentReaction commentReaction)
        {
            _context.Add(commentReaction);
            _context.SaveChanges();
        }

        public void AddReaction(Reaction reaction)
        {
            _context.Add(reaction);
            _context.SaveChanges();
        }

        public CommentReaction FindCommentReaction(int userId, int commentId)
        {
            return _context.CommentReactions.FirstOrDefault(r => r.UserId == userId && r.CommentId == commentId && r.Upvote == true);
        }

        public CommentReaction FindCommentReactionDown(int userId, int commentId)
        {
            return _context.CommentReactions.FirstOrDefault(r => r.UserId == userId && r.CommentId == commentId && r.Upvote == false);
        }

        public Reaction FindReaction(int userId, int postId)
        {
            return _context.Reactions.FirstOrDefault(r => r.UserId == userId && r.PostId == postId && r.Upvote == true);
        }

        public Reaction FindReactionDown(int userId, int postId)
        {
            return _context.Reactions.FirstOrDefault(r => r.UserId == userId && r.PostId == postId && r.Upvote == false);
        }

        public Notification GetNotificationByReaction(string url, string sendername)
        {
            return _context.Notifications.FirstOrDefault(n => n.Url == url && n.SenderName == sendername);
        }

        public void RemoveCommentReaction(CommentReaction commentReaction)
        {
            _context.Remove(commentReaction);
            _context.SaveChanges();
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
