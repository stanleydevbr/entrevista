using devbr.entrevista.domain.entities.questionarios;
using DevBr.Core.Dominio.Entidades;
using FluentValidation;

namespace devbr.entrevista.domain.entities.relatorios
{
    public class Relatorio : Entity<Relatorio>
    {
        public string Descricao { get; set; }
        public string PontosFortes { get; set; }
        public string PontosFracos { get; set; }
        public string Observacao { get; set; }
        public string Resultado { get; set; }
        public Entrevista Entrevista { get; set; }
        public Guid EntrevistaId { get; set; }
        public ICollection<Questionario> Questionarios { get; set; }

        public override bool EhValido()
        {
            RuleFor(e => e.Descricao)
                .NotEmpty()
                .WithMessage("A descrição é obrigatória")
                .MaximumLength(80)
                .WithMessage("A descrição precisa conter até 80 caracteres");

            RuleFor(e => e.Resultado)
                .NotEmpty()
                .WithMessage("O resultado é obrigatório")
                .MaximumLength(45)
                .WithMessage("A descrição precisa conter até 45 caracteres");

            ValidationResult = Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
