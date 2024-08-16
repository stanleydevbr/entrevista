using DevBr.Core.Dominio.ViewModels;

namespace DevBr.Entrevista.Application.ViewsModels
{
    public class CandidatoViewModel : ViewModelCore
    {
        public string Nome { get; set; }
        public CandidatoViewModel()
        {
            Id = Guid.NewGuid();
        }
    }
}
