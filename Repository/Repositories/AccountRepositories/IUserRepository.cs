using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.AccountRepositories
{
   public interface IUserRepository
    {
        User Login(string username, string password);
        bool UserExsist(string username);
        User CheckByToken(string token);
        void UpdateToken(int id, string token);
        public bool CheckEmail(string email);
        public bool CheckUserName(string username);
        public User Register(User user);
        public UserData AddUserData(UserData model);
        public UserSocial AddUserSocial(UserSocial model);
        public User GetUserByConfirmToken(string token);
        public void ConfirmUser(User user);
    }
}
