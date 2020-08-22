using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System.Collections.Generic;
using System.Linq;

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
            return _context.Posts
                                 .Include("Comments")
                                 .Include("User")
                                 .OrderByDescending(p=>p.AddedDate).ToList();
        }

        public ICollection<User> GetUsers()
        {
            return _context.Users.ToList();
        }
    }
}
