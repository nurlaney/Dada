using Microsoft.AspNetCore.SignalR;
using Repository.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Dada.Hubs
{
    public class NotificationHub : Hub
    {
        private readonly DadaDbContext _context;

        public NotificationHub(DadaDbContext context)
        {
            _context = context;
        }
        public async Task GroupNotify(string user, string message)
        {

            var senduser = _context.Users.FirstOrDefault(u => u.Username == user);

            await Clients.User(senduser.Username).SendAsync("RecieveMessage", message);

        }

    }
}

