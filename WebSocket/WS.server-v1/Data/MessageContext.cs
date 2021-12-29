using WS.server.Models;
using Microsoft.EntityFrameworkCore;
using System.Net.WebSockets;

namespace WS.server.Data {
    public class MessageContext : DbContext {

        public DbSet<Message> Mensagens { get; set; }

        public MessageContext( DbContextOptions<MessageContext> options )
            : base( options: options ) { }

    }

}
