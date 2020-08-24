using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;
using Repository.Data;
using Repository.Models;
using Repository.Repositories.ProfileRepositories;
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
        public async Task SendMessage(string message,string connectionid)
        {
            var httpContext = this.Context.GetHttpContext();

            var token = httpContext.Request.Cookies["user-token"];
            var myprofile = _profileRepository.GetUserByToken(token);

            await Clients.Client(connectionid).SendAsync("RecieveMessage", message);
        }
    }
}

