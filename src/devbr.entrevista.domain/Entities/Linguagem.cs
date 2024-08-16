using DevBr.Core.Dominio.Entidades;
using FluentValidation;

namespace devbr.entrevista.domain.entities
{
    public class Linguagem : Entity<Linguagem>
    {
        public string Descricao { get; set; }

        public virtual List<Entrevistador>? Entrevistadores { get; set; } 

        public Linguagem()
        {
            Id = Guid.NewGuid();
        }

        public override bool EhValido()
        {
            RuleFor(x => x.Descricao)
                .NotEmpty()
                .WithMessage("A descrição da linguagem e obrigatória.")
                .MaximumLength(45)
                .WithMessage("O tamanho máximo da descrição e de 45 caracteres.");

            ValidationResult = Validate(this);

            return ValidationResult.IsValid;
        }
    }
}
