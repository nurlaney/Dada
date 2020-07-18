using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.PostRepositories
{
   public interface IPostRepository
    {
        public Post GetPostById(int id);
    }
}
