using Microsoft.AspNetCore.SignalR;

namespace WebSocket_API.Hubs {
    public class chatHub : Hub {

        public async Task SendMessage( string message ) {
            await Clients.All.SendAsync("SendMessage", message );
            Console.WriteLine(message);
        }

    }
}
