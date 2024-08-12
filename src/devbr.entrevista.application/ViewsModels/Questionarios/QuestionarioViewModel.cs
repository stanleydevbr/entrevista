namespace DevBr.Entrevista.Application.ViewsModels.Questionarios
{
    public class QuestionarioViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Status { get; set; }
        public List<PerguntaViewModel> Perguntas { get; set; } = new List<PerguntaViewModel>();
    }
}
