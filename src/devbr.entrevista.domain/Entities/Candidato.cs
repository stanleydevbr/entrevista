using DevBr.Core.Dominio.Entidades;
using FluentValidation;

namespace devbr.entrevista.domain.entities
{
    public class Candidato : Entity<Candidato>
    {
        public string Nome { get; set; }

        public override bool EhValido()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("O nome do candidato é obrigatório.")
                .MaximumLength(200).WithMessage("O nome do candidato deve ter no máximo 200 caracteres.");

            ValidationResult = Validate(this);

            return ValidationResult.IsValid;
        }
    }
}
