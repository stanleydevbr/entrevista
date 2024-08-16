using DevBr.Core.Dominio.ViewModels;

namespace DevBr.Entrevista.Application.ViewsModels.Entrevistas
{
    public class RelatorioViewModel: ViewModelCore
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public string PontosFortes { get; set; }
        public string PontosFracos { get; set; }
        public string Observacao { get; set; }
        public string Resultado { get; set; }
        public EntrevistaViewModel? Entrevista { get; set; }

        public RelatorioViewModel()
        {
            Id = Guid.NewGuid();
        }
    }
}
