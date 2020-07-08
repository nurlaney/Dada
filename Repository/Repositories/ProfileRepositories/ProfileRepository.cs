﻿using Microsoft.EntityFrameworkCore;
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

        public Post GetPostByUsername(string username)
        {
            return _context.Posts.FirstOrDefault(p => p.User.Username == username);
        }

        public User GetProfile(string username)
        {
            return _context.Users
                                    .Include("GroupUsers")
                                    .Include(u => u.Posts)
                                    .Include("GroupUsers.Group")
                                    .FirstOrDefault(u => u.Username == username);
        } 

        public User GetUserByToken(string token)
        {
            return _context.Users
                                    .Include("GroupUsers")
                                    .Include(u => u.Posts)
                                    .Include("GroupUsers.Group")
                                    .FirstOrDefault(u => u.Token == token);
        }

        public User GetUserByUserName(string username)
        {
            return _context.Users
                                   .Include("GroupUsers")
                                   .Include("GroupUsers.Group")
                                   .Include(u => u.Posts)
                                   .FirstOrDefault(u => u.Username == username);
        }
    }
}
