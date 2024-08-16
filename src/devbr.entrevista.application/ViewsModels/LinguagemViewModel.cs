using DevBr.Core.Dominio.ViewModels;

namespace DevBr.Entrevista.Application.ViewsModels
{
    public class  LinguagemViewModel: ViewModelCore
    {
        public string Descricao { get; set; }
        public LinguagemViewModel()
        {
            Id = Guid.NewGuid();
        }
    }
}
