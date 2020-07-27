using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.SearchRepositories
{
   public interface ISearchRepository
    {
        public IEnumerable<User> GetMembers();
    }
}
