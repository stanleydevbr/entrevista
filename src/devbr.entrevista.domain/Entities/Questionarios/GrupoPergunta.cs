using DevBr.Core.Dominio.Entidades;

namespace devbr.entrevista.domain.entities.questionarios
{
    public class GrupoPergunta : Entity<GrupoPergunta>
    {
        public string Descricao { get; set; }
        public ICollection<Pergunta> Perguntas { get; set; }

        public override bool EhValido()
        {
            throw new NotImplementedException();
        }
    }
}
