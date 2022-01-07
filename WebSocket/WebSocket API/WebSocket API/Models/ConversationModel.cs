namespace WebSocket_API.Models {
    public class ConversationModel {
        public int id {get; set;}
        public GroupModel ConversationGroup { get; set; }
        public UserModel UserAdmin { get; set; }
        public List<HistoryModel> History { get; set; }
    }
}
