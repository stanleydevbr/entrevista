namespace DevBr.Entrevista.Application.ViewsModels.Questionarios
{
    public class PerguntaViewModel
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public string Resposta { get; set; }
        public bool Status { get; set; }
        public GrupoViewModel? GrupoResposta { get; set; }
        public PerguntaViewModel()
        {
            Id = Guid.NewGuid();
        }
    }
}
