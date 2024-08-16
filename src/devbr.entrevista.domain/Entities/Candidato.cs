using DevBr.Core.Dominio.Entidades;
using FluentValidation;

namespace devbr.entrevista.domain.entities
{
    public class Candidato : Entity<Candidato>
    {
        public Candidato()
        {
            Id = Guid.NewGuid();
        }
        public string Nome { get; set; }

        public virtual ICollection<Entrevistar>? Entrevistas { get; set; } 

        public override bool EhValido()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("O nome do candidato é obrigatório.")
                .MaximumLength(80).WithMessage("O nome do candidato deve ter no máximo 80 caracteres.");

            ValidationResult = Validate(this);

            return ValidationResult.IsValid;
        }
    }
}
