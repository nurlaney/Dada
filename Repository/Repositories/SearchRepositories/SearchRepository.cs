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

        public IEnumerable<User> GetMembers()
        {
            return _context.Users.ToList();
        }
    }
}
