using DevBr.Core.Dominio.Entidades;

namespace devbr.entrevista.domain.entities
{
    public class Agenda : Entity<Agenda>
    {
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public override bool EhValido()
        {
            throw new NotImplementedException();
        }
    }
}
