using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.MainRepositories
{
   public class MainRepositories: IMainRepositories
    {
        private readonly DadaDbContext _context;

        public MainRepositories(DadaDbContext context)
        {
            _context = context;
        }

        public ICollection<Group> GetGroups()
        {
            return _context.Groups.ToList();
        }

        public ICollection<Post> GetPosts()
        {
            return _context.Posts.OrderByDescending(p=>p.AddedDate).ToList();
        }

        public ICollection<User> GetUsers()
        {
            return _context.Users.ToList();
        }
    }
}
