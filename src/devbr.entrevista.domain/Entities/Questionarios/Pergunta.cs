using DevBr.Core.Dominio.Entidades;
using FluentValidation;

namespace devbr.entrevista.domain.entities.questionarios
{
    public class Pergunta : Entity<Pergunta>
    {
        public string Descricao { get; set; }
        public string Resposta { get; set; }
        public bool Status { get; set; }
        public GrupoPergunta GrupoPergunta { get; set; }
        public Guid GrupoPerguntaId { get; set; }
        public ICollection<Questionario> Questionarios { get; set; }
        public override bool EhValido()
        {
            RuleFor(e => e.Descricao)
                .NotEmpty()
                .WithMessage("A descrição é obrigatória.")
                .MaximumLength(45)
                .WithMessage("A descrição precisa conter 45 caracteres");

            RuleFor(e => e.Resposta)
                .NotEmpty()
                .WithMessage("A resposta é obrigatória");

            RuleFor(e => e.Status)
                .NotNull()
                .WithMessage("O status é obrigatório");
 

            ValidationResult = Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
