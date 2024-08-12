using DevBr.Core.Dominio.Entidades;

namespace devbr.entrevista.domain.entities.questionarios
{
    public class Pergunta : Entity<Pergunta>
    {
        public string Descricao { get; set; }
        public string Resposta { get; set; }
        public bool Status { get; set; }
        public GrupoPergunta GrupoPergunta { get; set; }
        public Guid GrupoPerguntaId { get; set; }
        public ICollection<Questionario> Questionarios { get; set; }
        public override bool EhValido()
        {
            throw new NotImplementedException();
        }
    }
}
