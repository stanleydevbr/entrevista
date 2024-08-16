using DevBr.Core.Dominio.ViewModels;

namespace DevBr.Entrevista.Application.ViewsModels.Questionarios
{
    public class QuestionarioViewModel: ViewModelCore
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Status { get; set; }
        public List<PerguntaViewModel>? Perguntas { get; set; }
        public QuestionarioViewModel()
        {
            Id = Guid.NewGuid();
        }
    }
}
