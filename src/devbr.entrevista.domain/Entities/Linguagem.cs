using DevBr.Core.Dominio.Entidades;
using FluentValidation;

namespace devbr.entrevista.domain.entities
{
    public class Linguagem : Entity<Linguagem>
    {
        public string Descricao { get; set; }
        public override bool EhValido()
        {
            throw new NotImplementedException();
        }
    }
}
