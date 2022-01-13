using Microsoft.EntityFrameworkCore;
using WebSocket_API.Models;

namespace WebSocket_API.DTO {
    public class DBMemoryContext : DbContext {

        public DbSet<ConversationModel> Conversa { get; set; }
        public DbSet<botaoModel> BotoesColetor { get; set; }
        public DbSet<GroupModel> GruposColetorContext{ get; set; }


        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder ) {
            optionsBuilder.UseInMemoryDatabase( "conversation" );
        }

    }
}
