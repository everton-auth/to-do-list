namespace WebSocket_API.Models {
    public class HistoryModel {
        public int id { get; set; }
        public string username { get; set; }
        public int status { get; set; }
        public DateTime DateSend { get; set; }
        public string message { get; set; }
        public string UserRead { get; set; }
    }
}
