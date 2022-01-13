using WebSocket_API.DTO;
using WebSocket_API.Models;

namespace WebSocket_API.Business {
    public class GroupsBusiness {

        public List<GroupModel> GetAllGroups() {
            return new List<GroupModel>();
        }

        public void AddGroup( GroupModel group ) {
            using( DBMemoryContext Context = new DBMemoryContext() ) {
                Context.Add( group );
            }
        }

        public void AddToGroup( UserModel user , string group ) {
            try {
                using( DBMemoryContext Context = new DBMemoryContext() ) {
                    var predicate = Context.GruposColetorContext.SingleOrDefault( grupo => grupo.name == group );
                    predicate.Users.Add( user );
                    Context.SaveChanges();
                }
            } catch( Exception ex ) {
                throw ex;
            }
        }

        public GroupModel GetGroupByName( string name ) {
            using( DBMemoryContext Context = new DBMemoryContext() ) {
                return Context.GruposColetorContext.Find( new GroupModel { name = name } );
            }

        }

        public void DeleteGroup( int id ) { }
    }
}
