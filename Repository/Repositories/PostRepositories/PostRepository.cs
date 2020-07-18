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
