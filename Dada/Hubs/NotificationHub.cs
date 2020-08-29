using Microsoft.AspNetCore.SignalR;
using Repository.Data;
using Repository.Models;
using Repository.Repositories.ProfileRepositories;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Dada.Hubs
{
    public class NotificationHub : Hub
    {
        private readonly DadaDbContext _context;
        private readonly IProfileRepository _profileRepository;

        public NotificationHub(DadaDbContext context,
                                IProfileRepository profileRepository)
        {
            _context = context;
            _profileRepository = profileRepository;
        }
        public override async Task OnConnectedAsync()
        {
            var httpContext = this.Context.GetHttpContext();

           var token = httpContext.Request.Cookies["user-token"];
           var myprofile = _profileRepository.GetUserByToken(token);

            myprofile.ConectionId = Context.ConnectionId;

            _context.SaveChanges();

        }
        public async Task SendMessage(string text,string connectionid,string url,string senderName)
        {
            
            var httpContext = this.Context.GetHttpContext();

            var token = httpContext.Request.Cookies["user-token"];
            var myprofile = _profileRepository.GetUserByToken(token);

            var recipient = _context.Users.FirstOrDefault(u => u.ConectionId == connectionid);

            Notification notification = new Notification
            {
                IsRead = false,
                Url = url,
                SenderName = senderName,
                SendDate = DateTime.Now,
                UserId = recipient.Id,
                Text = text
            };

            _context.Add(notification);
            _context.SaveChanges();

            await Clients.Client(connectionid).SendAsync("RecieveMessage", text,url,senderName);
        }

        public async Task DownVote(string text, string connectionid, string url, string senderName)
        {

            var httpContext = this.Context.GetHttpContext();

            var token = httpContext.Request.Cookies["user-token"];
            var myprofile = _profileRepository.GetUserByToken(token);

            var recipient = _context.Users.FirstOrDefault(u => u.ConectionId == connectionid);

            Notification notification = new Notification
            {
                IsRead = false,
                Url = url,
                SenderName = senderName,
                SendDate = DateTime.Now,
                UserId = recipient.Id,
                Text = text
            };

            _context.Add(notification);
            _context.SaveChanges();

            await Clients.Client(connectionid).SendAsync("RecieveDownNotify", text, url, senderName);
        }

        public async Task Upvotec(string text, string connectionid, string url, string senderName)
        {

            var httpContext = this.Context.GetHttpContext();

            var token = httpContext.Request.Cookies["user-token"];
            var myprofile = _profileRepository.GetUserByToken(token);

            var recipient = _context.Users.FirstOrDefault(u => u.ConectionId == connectionid);

            Notification notification = new Notification
            {
                IsRead = false,
                Url = url,
                SenderName = senderName,
                SendDate = DateTime.Now,
                UserId = recipient.Id,
                Text = text
            };

            _context.Add(notification);
            _context.SaveChanges();

            await Clients.Client(connectionid).SendAsync("RecieveUpvotec", text, url, senderName);
        }
        public async Task DownVotec(string text, string connectionid, string url, string senderName)
        {

            var httpContext = this.Context.GetHttpContext();

            var token = httpContext.Request.Cookies["user-token"];
            var myprofile = _profileRepository.GetUserByToken(token);

            var recipient = _context.Users.FirstOrDefault(u => u.ConectionId == connectionid);

            Notification notification = new Notification
            {
                IsRead = false,
                Url = url,
                SenderName = senderName,
                SendDate = DateTime.Now,
                UserId = recipient.Id,
                Text = text
            };

            _context.Add(notification);
            _context.SaveChanges();

            await Clients.Client(connectionid).SendAsync("RecieveDownNotify", text, url, senderName);
        }
    }
}

