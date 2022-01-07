namespace WebSocket_API.Models {
    public class UserModel {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public List<GroupModel> Groups { get; set; }
        public List<HistoryModel> History { get; set; }
    }
}
