using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Repository.Repositories.PostRepositories
{
   public class PostRepository : IPostRepository
    {
        private readonly DadaDbContext _context;

        public PostRepository(DadaDbContext context)
        {
            _context = context;
        }

        public Comment AddComment(Comment comment)
        {
            _context.Add(comment);
            _context.SaveChanges();

            return comment;
        }

        public Comment DeleteComment(Comment comment)
        {
            _context.Remove(comment);
            _context.SaveChanges();

            return comment;
        }

        public Comment GetCommentById(int id)
        {
            return _context.Comments.FirstOrDefault(c => c.Id == id);
        }

        public Post GetPostById(int id)
        {
            return _context.Posts
                                 .Include(p=>p.Group)
                                 .Include(p => p.Comments)
                                 .Include("Comments.User")
                                 .FirstOrDefault(p => p.Id == id);
        }   
    }
}
