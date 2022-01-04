using Microsoft.AspNetCore.SignalR;

namespace WebSocket_API.Hubs {
    public class coletorHub : Hub {

        public async Task NewGroup( string name , string userID ) {
            try {
                Clients.Group( name );
                //await Clients.User( userID ).SendAsync( $"Grupo {name} criado com sucesso!" );
            } catch( Exception ex ) {
                await Clients.User( userID ).SendAsync( ex.ToString() );
            }

        }
    }
}
