using DevBr.Core.Dominio.Entidades;
using FluentValidation;

namespace devbr.entrevista.domain.entities.questionarios
{
    public class GrupoPergunta : Entity<GrupoPergunta>
    {
        public string Descricao { get; set; }
        public List<Pergunta>? Perguntas { get; set; } 

        public GrupoPergunta()
        {
            Id = Guid.NewGuid();
        }

        public override bool EhValido()
        {

            RuleFor(e => e.Descricao)
                .NotEmpty()
                .WithMessage("A descrição é obrigatória.")
                .MaximumLength(45)
                .WithMessage("A descrição precisa conter até 45 caracteres");
                
            ValidationResult = Validate(this);
            return ValidationResult.IsValid;

        }
    }
}
