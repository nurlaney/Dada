using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.ReactionRepositories
{
   public interface IReactionRepository
    {
        public void AddReaction(Reaction reaction);
        public Reaction FindReaction(int userId,int postId);
        public void RemoveReaction(Reaction reaction);
    }
}
