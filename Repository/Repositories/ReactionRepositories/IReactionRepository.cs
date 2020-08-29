using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.ReactionRepositories
{
   public interface IReactionRepository
    {
        public void AddReaction(Reaction reaction);
        public void AddCommentReaction(CommentReaction commentReaction);
        public Reaction FindReaction(int userId,int postId);
        public CommentReaction FindCommentReaction(int userId, int commentId);
        public CommentReaction FindCommentReactionDown(int userId, int commentId);
        public Reaction FindReactionDown(int userId, int postId);
        public void RemoveReaction(Reaction reaction);
        public void RemoveCommentReaction(CommentReaction commentReaction);
        public Notification GetNotificationByReaction(string url, string sendername);
        public void RemoveNotify(Notification notification);
    }
}
