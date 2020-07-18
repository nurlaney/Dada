using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.MainRepositories
{
   public interface IMainRepositories
    {
        public ICollection<Post> GetPosts();
        public ICollection<User> GetUsers();
        public ICollection<Group> GetGroups();
    }
}
