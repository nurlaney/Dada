using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.ProfileRepositories
{
   public class ProfileRepository : IProfileRepository
    {
        private readonly DadaDbContext _context;

        public ProfileRepository(DadaDbContext context)
        {
            _context = context;
        }

        public Post CreatePost(Post model)
        {
            _context.Posts.Add(model);
            _context.SaveChanges();

            return model;
        }

        public Post DeletePost(Post post)
        {
            _context.Remove(post);
            _context.SaveChanges();

            return post;
        }

        public ICollection<Notification> GetNotificationsById(int id)
        {
            return _context.Notifications.Where(n => n.UserId == id && n.IsRead == false).ToList();
        }

        public Post GetPostById(int id)
        {
           return _context.Posts.Include(p=>p.Comments).Include("Reactions").FirstOrDefault(p => p.Id == id);
        }

        public Post GetPostByUsername(string username)
        {
            return _context.Posts.Include("Reactions").FirstOrDefault(p => p.User.Username == username);
        }

        public User GetProfile(string username)
        {
            return _context.Users
                                    .Include("GroupUsers")
                                    .Include(u => u.Posts)
                                    .Include("Comments")
                                    .Include("UserData")
                                    .Include("UserSocial")
                                    .Include("GroupUsers.Group")
                                    .Include("Reactions")
                                    .FirstOrDefault(u => u.Username == username);
        } 

        public User GetUserByToken(string token)
        {
            return _context.Users
                                    .Include("GroupUsers")
                                    .Include(u => u.Posts)
                                    .Include("Comments")
                                    .Include("UserData")
                                    .Include("UserSocial")
                                    .Include("GroupUsers.Group")
                                    .Include(u=>u.Notifications)
                                    .Include("Reactions")
                                    .FirstOrDefault(u => u.Token == token);
        }

        public User GetUserByUserName(string username)
        {
            return _context.Users
                                   .Include("GroupUsers")
                                   .Include("GroupUsers.Group")
                                   .Include("Comments")
                                   .Include("UserData")
                                   .Include("UserSocial")
                                   .Include(u => u.Posts)
                                   .Include("Reactions")
                                   .FirstOrDefault(u => u.Username == username);
        }

        public void SetNotifyRead(ICollection<Notification> notifications)
        {
            foreach (var item in notifications)
            {
                item.IsRead = true;
            }
            _context.SaveChanges();
        }
    }
}
