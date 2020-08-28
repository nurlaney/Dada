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

        public void RemoveReaction(Reaction reaction)
        {
            _context.Remove(reaction);
            _context.SaveChanges();
        }
    }
}
