namespace WebSocket_API.Models {
    public class GroupModel {
        public int id { get; set; }
        public string name { get; set; }
        public List<UserModel> Users { get; set; }
        public List<HistoryModel> History { get; set; }

    }
}
