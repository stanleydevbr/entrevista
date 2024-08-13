using DevBr.Core.Dominio.Entidades;
using FluentValidation;

namespace devbr.entrevista.domain.entities.relatorios
{
    public class NivelConhecimento : Entity<NivelConhecimento>
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }

        public List<Resposta> Respostas { get; set; }
        public override bool EhValido()
        {
            RuleFor(e => e.Descricao)
              .NotEmpty()
              .WithMessage("A descrição é obrigatória")
              .MaximumLength(45)
              .WithMessage("A descrição precisa conter até 45 caracteres");

            ValidationResult = Validate(this);
            return ValidationResult.IsValid;

        }
    }
}
