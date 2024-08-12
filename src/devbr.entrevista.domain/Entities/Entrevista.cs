using DevBr.Core.Dominio.Entidades;

namespace devbr.entrevista.domain.entities
{
    public class Entrevista : Entity<Entrevista>
    {
        public DateTime DataEntrevista { get; set; }
        public string NivelEsperado { get; set; }
        public Guid CandidatoId { get; set; }
        public Candidato Candidato { get; set; }

        public override bool EhValido()
        {
            throw new NotImplementedException();
        }
    }
}
