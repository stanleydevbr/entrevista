using DevBr.Core.Dominio.Entidades;

namespace devbr.entrevista.domain.entities
{
    public class Entrevistador : Entity<Entrevistador>
    {
        public string Nome { get; set; }
        public string Cliente { get; set; }
        public string Familia { get; set; }
        public string Nivel { get; set; }
        public List<Linguagem> Linguagens { get; set; }
        public override bool EhValido()
        {
            throw new NotImplementedException();
        }
    }
}
