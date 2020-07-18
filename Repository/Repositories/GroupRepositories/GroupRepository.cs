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
        public Group GetGroupById(int id)
        {
            return _context.Groups
                                  .Include(g=>g.GroupUsers)
                                  .Include("GroupUsers.User")
                                  .Include(g=>g.Posts)
                                  .FirstOrDefault(g => g.Id == id);
        }
    }
}
