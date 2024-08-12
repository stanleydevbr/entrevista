using DevBr.Core.Dominio.Entidades;
using FluentValidation;

namespace devbr.entrevista.domain.entities
{
    public class Entrevistador : Entity<Entrevistador>
    {
        public string Nome { get; set; }
        public string Cliente { get; set; }
        public string Familia { get; set; }
        public string Nivel { get; set; }
        public List<Entrevista> Entrevistas { get; set; }
        public List<Linguagem> Linguagens { get; set; }
        public override bool EhValido()
        {
            RuleFor(e => e.Nome)
                .NotEmpty()
                .WithMessage("O nome do entrevistador é obrigatório.");

            RuleFor(e => e.Cliente)
                .MaximumLength(80)
                .WithMessage("O nome do entrevistador deve ter no máximo 80 caracteres.");

            ValidationResult = Validate(this);

            return ValidationResult.IsValid;
        }
    }
}
