using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using WebSocket_API.Models;

namespace WebSocket_API {
    public class GrupoHub : Hub {

        public async Task GetStatus( string maquina ) {
            await Clients.Group( maquina ).SendAsync( "Online" );
        }


    }
}
