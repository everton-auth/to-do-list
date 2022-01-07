namespace WebSocket_API.Models {
    public class FirstData {

        public TabelaModel GetEstruturaTabela( string tabela , string maquina ) {

            List<TabelaModel> ListaTabelas = new List<TabelaModel> {
                new TabelaModel {
                    maquina= "2007",
                    filtro = "",
                    titulo = "nao-conformidade",
                    estrutura = new List<EstruturaTabelaModel>{
                        new EstruturaTabelaModel {
                        nomeColuna="RNC",
                        nomeDadoRenderizado = "",
                        },
                        new EstruturaTabelaModel {
                        nomeColuna="Data",
                        nomeDadoRenderizado = "",
                        },
                        new EstruturaTabelaModel {
                        nomeColuna="Tipo Desc",
                        nomeDadoRenderizado = "",
                        },
                        new EstruturaTabelaModel {
                        nomeColuna="Setor",
                        nomeDadoRenderizado = "",
                        },
                        new EstruturaTabelaModel {
                        nomeColuna="Turno",
                        nomeDadoRenderizado = "",
                        },
                        new EstruturaTabelaModel {
                        nomeColuna="Motivo",
                        nomeDadoRenderizado = "",
                        },
                        new EstruturaTabelaModel {
                        nomeColuna="Quantidade",
                        nomeDadoRenderizado = "",
                        },
                        new EstruturaTabelaModel {
                        nomeColuna="Situação",
                        nomeDadoRenderizado = "",
                        },
                        new EstruturaTabelaModel {
                        nomeColuna="Descrição",
                        nomeDadoRenderizado = "",
                        },
                        new EstruturaTabelaModel {
                        nomeColuna="Ação Imediata",
                        nomeDadoRenderizado = "",
                        },
                        new EstruturaTabelaModel {
                        nomeColuna="Causa Fundamental",
                        nomeDadoRenderizado = "",
                        },
                        new EstruturaTabelaModel {
                        nomeColuna="Ação Corretiva",
                        nomeDadoRenderizado = "",
                        }
                    }
                }
            };
            return ListaTabelas.Find( tab => tab.titulo == tabela );
        }

        public List<ConversationModel> PopularConversation() {
            return new List<ConversationModel> {
            new ConversationModel {
                id = 1,
                ConversationGroup = new GroupModel {
                    id=1,
                    name ="2007"
                },
            }
            };
        }

    }
}
