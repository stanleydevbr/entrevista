using DevBr.Core.Dominio.ViewModels;

namespace DevBr.Entrevista.Application.ViewsModels.Entrevistas
{
    public class EntrevistaViewModel: ViewModelCore
    {
        public EntrevistaViewModel()
        {
            Id = Guid.NewGuid();
        }
        public DateTime DataEntrevista { get; set; }
        public string NivelEsperado { get; set; }
        //public CandidatoViewModel Candidato { get; set; }
        //public List<EntrevistadorViewModel>? Entrevistadores { get; set; } 
    }
}
