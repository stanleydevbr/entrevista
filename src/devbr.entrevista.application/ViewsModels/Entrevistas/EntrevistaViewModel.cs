using DevBr.Core.Dominio.ViewModels;

namespace DevBr.Entrevista.Application.ViewsModels.Entrevistas
{
    public class EntrevistaViewModel: ViewModelCore
    {
        public Guid Id { get; set; }
        public CandidatoViewModel Candidato { get; set; }
        public DateTime DataEntrevista { get; set; }
        public string NivelEsperado { get; set; }
        public List<EntrevistadorViewModel> Entrevistadores { get; set; }
    }
}
