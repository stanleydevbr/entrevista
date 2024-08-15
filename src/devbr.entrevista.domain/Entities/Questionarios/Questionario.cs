
using DevBr.Core.Dominio.Entidades;
using FluentValidation;
using devbr.entrevista.domain.entities.relatorios;

namespace devbr.entrevista.domain.entities.questionarios
{
    public class Questionario : Entity<Questionario>
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Status { get; set; }
        public ICollection<Pergunta> Perguntas { get; set; }
        public ICollection<Relatorio> Relatorios { get; set; }

        public override bool EhValido()
        {
            RuleFor(e => e.Nome)
                .NotEmpty()
                .WithMessage("O nome é obrigatório")
                .MaximumLength(45)
                .WithMessage("A descrição precisa conter até 45 caracteres");

            RuleFor(e => e.Descricao)
                .NotEmpty()
                .WithMessage("A descrição é obrigatória")
                .MaximumLength(250)
                .WithMessage("A descrição precisa conter até 250 caracteres");

            RuleFor(e => e.Status)
                .NotNull()
                .WithMessage("O status é obrigatório");

            ValidationResult = Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
