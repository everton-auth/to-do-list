using Microsoft.AspNetCore.SignalR;

namespace WebSocket_API.Hubs {
    public class chatHub : Hub {

        public async Task SendMessage( string message ) {
            await Clients.All.SendAsync( "SendMessage" , message );
        }

        public async Task AddToGroup( string groupName , string user ) {
            await Groups.AddToGroupAsync( user , groupName );

            await Clients.Group( groupName ).SendAsync( "SendMessage" , $"{Context.ConnectionId} Entrou no grupo." );
        }

        public async Task RemoveFromGroup( string groupName ) {
            await Groups.RemoveFromGroupAsync( Context.ConnectionId , groupName );

            await Clients.Group( groupName ).SendAsync( "SendMessage" , $"{Context.ConnectionId} Saiu do grupo." );
        }
        public async Task SendMesssageToGroup( string groupName , string message ) {
            await Clients.Group( groupName ).SendAsync( "SendMessage" , message );
        }

        public async Task SendMessagePrivate( string message , string user ) {
            await Clients.User( user ).SendAsync( message );
        }

        public async Task CreateGroup( string groupName ) {
            await Groups.AddToGroupAsync( Context.ConnectionId , groupName );

            await Clients.Group( groupName ).SendAsync( "SendMessage" , $"Grupo {groupName} foi criado com sucesso!" );
        }

        public async Task SendWarning( string user ) {

        }
        public async Task SendWarningGroup( string groupName ) {

        }
    }
}
