using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.SearchRepositories
{
   public class SearchRepository : ISearchRepository
    {
        private readonly DadaDbContext _context;

        public SearchRepository(DadaDbContext context)
        {
            _context = context;
        }

        public IList<Group> GetGroups(string term)
        {
            return _context.Groups.Where(u => u.Name.Contains(term)).ToList();
        }

        public IList<User> GetMembers(string term)
        {
            return _context.Users.Where(u => u.Username.Contains(term)).ToList();   
        }

        public IList<Post> GetPostTitles(string term)
        {
            return _context.Posts.Where(u => u.Title.Contains(term)).ToList();
        }
    }
}
