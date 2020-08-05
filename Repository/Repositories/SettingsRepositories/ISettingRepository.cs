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
        public UserSocial GetSocials(int id);
        public UserData GetUserDatas(int id);
        public void UpdateSocialMedia(UserSocial userSocial, UserSocial updateToSocial);
        public void UpdateUserDatas(UserData userData, UserData updateData);
    }
}
