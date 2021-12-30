using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using WebSocket_API.Services;

namespace WebSocket_API {
    public class Chat : Hub {

        public async Task NewMessage( string chat , string message ) {

            await Clients.All.SendAsync( "NewMessage" , chat , message );

        }

    }
}