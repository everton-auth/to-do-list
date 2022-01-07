namespace WebSocket_API.Models {
    public class TabelaModel {
        public int Id { get; }
        public string maquina { get; set; }
        public string titulo { get; set; }
        public string filtro { get; set; }
        public List<EstruturaTabelaModel> estrutura;
    }
}
