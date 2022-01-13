using Microsoft.AspNetCore.SignalR;
using WebSocket_API.Models;
using WebSocket_API.DTO;
using MESP_API.Business;
using Commons;
using WebSocket_API.Business;

namespace WebSocket_API.Hubs {
    public class coletorHub : Hub {
        // Lista de usuários
        public static List<UserModel> UserList = new List<UserModel>();

        public GroupsBusiness GruposBusiness = new GroupsBusiness();

        public Task OnDisconnectedAsync( Exception exception ) {
            return base.OnDisconnectedAsync( exception );
        }

        public async Task EnterMaquinaGroupAsync( UserModel user , string maquina ) {
            Groups.AddToGroupAsync( user.Id , maquina );
            GruposBusiness.AddToGroup(user, maquina);
            await Clients.Group( maquina ).SendAsync( "SendAsyncWarning" , $"Usuário ${user.Name} foi adicionado a máquina {maquina}" );
        }

        public async Task getProgramacaoMaquna( string maquina ) {
            await Clients.Group( maquina ).SendAsync( "Programacao" , "" );
        }


        public async Task SendAsyncWarning( string message ) {
           
        }
    }
}
