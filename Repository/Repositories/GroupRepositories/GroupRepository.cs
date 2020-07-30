using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.GroupRepositories
{
    public class GroupRepository : IGroupRepository
    {
        private readonly DadaDbContext _context;

        public GroupRepository(DadaDbContext context)
        {
            _context = context;
        }

        public List<User> FindGroupAdmins(int groupId)
        {
            return _context.GroupUsers.Where(g => g.GroupId == groupId && g.RoleId == 1).Select(g => g.User).ToList();
        }

        public Group GetGroupById(int id)
        {
            return _context.Groups
                                  .Include(g=>g.GroupUsers)
                                  .Include("GroupUsers.User")
                                  .Include(g=>g.Posts)
                                  .FirstOrDefault(g => g.Id == id);
        }

        public GroupUser GetGroupHub(int groupId, int userId)
        {
            return _context.GroupUsers.FirstOrDefault(g => g.GroupId == groupId && g.UserId == userId);
        }

        public GroupUser GetGroupHub(int id)
        {
            return _context.GroupUsers.FirstOrDefault(g => g.Id == id);
        }

        public bool IsJoined(int groupId, int userId)
        {
            return _context.GroupUsers.Any(g => g.GroupId == groupId && g.UserId == userId);
        }
    }
}
