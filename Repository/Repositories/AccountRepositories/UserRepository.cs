using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.AccountRepositories
{
   public class UserRepository : IUserRepository
    {
        private readonly DadaDbContext _context;

        public UserRepository(DadaDbContext context)
        {
            _context = context;
        }

        public UserData AddUserData(UserData model)
        {
            _context.Add(model);
            _context.SaveChanges();

            return model;
        }

        public UserSocial AddUserSocial(UserSocial model)
        {
            _context.Add(model);

            return model;
        }

        public User CheckByToken(string token)
        {
            return _context.Users
                                 .Include(u=>u.UserData)
                                 .Include(u=>u.UserSocial)
                                 .FirstOrDefault(a => a.Token == token);
        }

        public bool CheckEmail(string email)
        {
            return _context.Users.Any(u => u.Email == email);
        }

        public bool CheckUserName(string username)
        {
            return _context.Users.Any(u => u.Username == username);
        }

        public void ConfirmUser(User user)
        {
            user.EmailConfirmed = true;

            _context.SaveChanges();
        }

        public User GetUserByConfirmToken(string token)
        {
            return _context.Users.FirstOrDefault(u => u.ConfirmToken == token);

        }

        public User Login(string username, string password)
        {
            User user = _context.Users.FirstOrDefault(a => a.Username == username);

            if (user != null && CryptoHelper.Crypto.VerifyHashedPassword(user.Password, password))
            {
                return user;
            }

            return null;
        }

        public User Register(User user)
        {
            user.Password = CryptoHelper.Crypto.HashPassword(user.Password);

            _context.Add(user);
            _context.SaveChanges();

            return user;
        }

        public void UpdateToken(int id, string token)
        {
            User user = _context.Users.Find(id);

            user.Token = token;

            _context.SaveChanges();
        }

        public bool UserExsist(string username)
        {
            return _context.Users.Any(a => a.Username == username);
        }
    }
}
