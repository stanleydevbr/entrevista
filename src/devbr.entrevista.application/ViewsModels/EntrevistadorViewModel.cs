using DevBr.Core.Dominio.ViewModels;

namespace DevBr.Entrevista.Application.ViewsModels
{
    public class EntrevistadorViewModel: ViewModelCore
    {
        public string Nome { get; set; }
        public string Cliente { get; set; }
        public string Familia { get; set; }
        public string Nivel { get; set; }
        public List<LinguagemViewModel> Linguagens { get; set; }

    }
}
