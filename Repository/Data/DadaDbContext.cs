using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Data
{
  public  class DadaDbContext : DbContext
    {
        public DadaDbContext(DbContextOptions<DadaDbContext> options) : base(options) { }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Group > Groups { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserData> UserDatas { get; set; }
        public DbSet<UserSocial> UserSocials { get; set; }
        public DbSet<GroupUser> GroupUsers { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
