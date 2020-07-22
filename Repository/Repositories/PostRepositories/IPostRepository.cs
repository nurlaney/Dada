using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.PostRepositories
{
   public interface IPostRepository
    {
        public Post GetPostById(int id);

        public Comment GetCommentById(int id);

        public Comment AddComment(Comment comment);

        public Comment DeleteComment(Comment comment);
        
    }
}
