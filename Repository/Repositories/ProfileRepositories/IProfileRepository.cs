using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.ProfileRepositories
{
   public interface IProfileRepository
    {
        public User GetProfile(string username);

        public User GetUserByToken(string token);

        public User GetUserByUserName(string username);

        public Post GetPostByUsername(string username);

        public Post CreatePost(Post model);
    }
}
