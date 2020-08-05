using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.SettingsRepositories
{
    public class SettingRepository : ISettingRepository
    {
        private readonly DadaDbContext _context;

        public SettingRepository(DadaDbContext context)
        {
            _context = context;
        }

        public bool CheckEmail(int id, string email)
        {
            return _context.Users.Where(u => u.Id != id).Any(u => u.Email == email);
        }

        public bool CheckUserName(int id, string username)
        {
            return _context.Users.Where(u => u.Id != id).Any(u => u.Username == username);
        }

        public UserSocial GetSocials(int id)
        {
            return _context.UserSocials.FirstOrDefault(u => u.UserId == id);
        }

        public void UpdateSocialMedia(UserSocial userSocial, UserSocial updateToSocial)
        {
            updateToSocial.FbLink =  userSocial.FbLink;
            updateToSocial.GoogleLink = userSocial.GoogleLink;
            updateToSocial.InstaLink = userSocial.InstaLink;
            updateToSocial.PatreonLink = userSocial.PatreonLink;
            updateToSocial.TwitchLink = userSocial.TwitchLink;
            updateToSocial.TwitLink = userSocial.TwitLink;
            updateToSocial.YoutubeLink = userSocial.YoutubeLink;
            updateToSocial.DiscordLink = userSocial.DiscordLink;

            _context.SaveChanges();
        }

        public void UpdateUser(User user, User userToUpdate)
        {
            userToUpdate.Email = user.Email;
            userToUpdate.FullName = user.FullName;
            userToUpdate.Username = "d/" + user.Username;

            _context.SaveChanges();
        }
    }
}
