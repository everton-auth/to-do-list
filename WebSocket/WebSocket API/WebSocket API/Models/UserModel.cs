namespace WebSocket_API.Models {
    public class UserModel {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<GroupModel> Groups { get; set; }
    }
}
