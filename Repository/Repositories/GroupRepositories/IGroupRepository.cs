using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.GroupRepositories
{
  public interface IGroupRepository
    {
        public Group GetGroupById(int id);
        public List<User> FindGroupAdmins(int groupId);
        public bool IsJoined(int groupId, int userId);
        public GroupUser GetGroupHub(int groupId, int userId);
        public GroupUser GetGroupHub(int id);
        public GroupUser JoinGroup(GroupUser groupUser);
        public GroupUser LeaveGroup(GroupUser groupUser);
    }
}
