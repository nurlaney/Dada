using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.GroupRepositories
{
  public interface IGroupRepository
    {
        public Group GetGroupById(int id);
    }
}
