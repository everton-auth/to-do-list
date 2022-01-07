using Microsoft.AspNetCore.SignalR;
using WebSocket_API.DTO;
using WebSocket_API.Models;

namespace WebSocket_API.Hubs {
    public class TabelaHub : Hub {

        DBMemoryContext DbContext = new DBMemoryContext();
        FirstData firstData = new FirstData();

        public TabelaHub() {
            DbContext.AddAsync( firstData.PopularConversation() );
        }


        public async Task GetTabela( string user , string tabela , string maquina ) {
            FirstData EstruturaTabela = new FirstData();

            await Clients.User( user ).SendAsync( "SendData" , EstruturaTabela.GetEstruturaTabela( tabela , maquina ).estrutura );
        }

        public async Task AddToGroup( string groupName ) {
            await Groups.AddToGroupAsync( Context.ConnectionId , groupName );

            await Clients.Group( groupName ).SendAsync( "SendData" , $"{Context.ConnectionId} has joined the group {groupName}." );
        }

        public async Task RemoveFromGroup( string groupName ) {
            await Groups.RemoveFromGroupAsync( Context.ConnectionId , groupName );
            await Clients.Group( groupName ).SendAsync( "SendData" , $"{Context.ConnectionId} has left the group {groupName}." );
        }
        public async Task SendToGroup( string message , string groupName ) {
            await Clients.Group( groupName ).SendAsync( "SendGroup" , message );
        }
    }
}
