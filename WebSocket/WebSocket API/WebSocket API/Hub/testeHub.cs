using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace WebSocket_API {
    public class testeHub : Hub {

        public Task ConnectToStock( string symbol ) {
            Groups.AddToGroupAsync( Context.ConnectionId , symbol );
            return Task.CompletedTask;
        }
    }
}
