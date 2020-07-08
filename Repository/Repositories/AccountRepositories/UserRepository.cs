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

        public User CheckByToken(string token)
        {
            return _context.Users.FirstOrDefault(a => a.Token == token);
        }

        public User Login(string email, string password)
        {
            User user = _context.Users.FirstOrDefault(a => a.Email == email);

            if (user != null && CryptoHelper.Crypto.VerifyHashedPassword(user.Password, password))
            {
                return user;
            }

            return null;
        }

        public void UpdateToken(int id, string token)
        {
            User user = _context.Users.Find(id);

            user.Token = token;

            _context.SaveChanges();
        }

        public bool UserExsist(string email)
        {
            return _context.Users.Any(a => a.Email == email);
        }
    }
}
