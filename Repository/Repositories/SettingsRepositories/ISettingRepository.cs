using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.SettingsRepositories
{
   public interface ISettingRepository
    {
        public void UpdateUser(User user,User userToUpdate);
        public bool CheckUserName(int id, string username);
        public bool CheckEmail(int id, string email);
    }
}
