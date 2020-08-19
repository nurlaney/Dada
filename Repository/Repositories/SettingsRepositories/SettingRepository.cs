using Microsoft.EntityFrameworkCore;
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

        public GroupUser AddGroupUser(GroupUser groupUser)
        {
            _context.Add(groupUser);
            _context.SaveChanges();

            return groupUser;
        }

        public bool CheckEmail(int id, string email)
        {
            return _context.Users.Where(u => u.Id != id).Any(u => u.Email == email);
        }

        public bool CheckUserName(int id, string username)
        {
            return _context.Users.Where(u => u.Id != id).Any(u => u.Username == username);
        }

        public void CreateGroup(Group group)
        {
            _context.Add(group);
            _context.SaveChanges();
        }

        public Group DeleteGroup(Group group)
        {
            _context.Remove(group);
            _context.SaveChanges();

            return group;
        }

        public Group GetGroupById(int id)
        {
            return _context.Groups.Include(g=>g.Posts).FirstOrDefault(g => g.Id == id);
        }

        public List<Group> GetGroups(int userId)
        {
            return _context.GroupUsers.Where(g => g.UserId == userId && g.RoleId == 1).Select(g => g.Group).ToList();
        }

        public UserSocial GetSocials(int id)
        {
            return _context.UserSocials.FirstOrDefault(u => u.UserId == id);
        }

        public UserData GetUserDatas(int id)
        {
            return _context.UserDatas.FirstOrDefault(u => u.UserId == id);
        }

        public void UpdateGroup(Group group, Group groupToUpdate)
        {
            groupToUpdate.Info = group.Info;
            groupToUpdate.Name = "k/" + group.Name;
            groupToUpdate.Rules = group.Rules;
            groupToUpdate.Subtitle = group.Subtitle;

            _context.SaveChanges();
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

        public void UpdateUserDatas(UserData userData, UserData updateData)
        {
            updateData.AboutMe = userData.AboutMe;
            updateData.Birthday = userData.Birthday;
            updateData.City = userData.City;

            _context.SaveChanges();
        }
    }
}
