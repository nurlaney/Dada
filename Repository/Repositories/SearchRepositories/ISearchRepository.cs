using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.SearchRepositories
{
   public interface ISearchRepository
    {
        public IList<User> GetMembers(string term);
        public IList<Group> GetGroups(string term);
        public IList<Post> GetPostTitles(string term);
    }
}
