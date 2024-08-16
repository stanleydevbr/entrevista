using DevBr.Core.Dominio.Entidades;
using FluentValidation;

namespace devbr.entrevista.domain.entities.relatorios
{
    public class Resposta : Entity<Resposta>
    {
        public string Pergunta { get; set; }
        public string RespostaCandidato { get; set; }
        public string RespostaEsperada { get; set; }
        public int CodigoGrupoPergunta { get; set; }
        public string DescricaoGrupoPergunta { get; set; }
        public virtual NivelConhecimento? NivelConhecimento { get; set; } 
        public Guid NivelConhecimentoId { get; set; }
        public virtual Relatorio? Relatorio { get; set; } 
        public Guid RelatorioId { get; set; }
        public Resposta()
        {
            Id = Guid.NewGuid();

        }

        public override bool EhValido()
        {
            RuleFor(e => e.Pergunta)
                .NotEmpty()
                .WithMessage("A pergunta é obrigatória")
                .MaximumLength(500)
                .WithMessage("A pergunta precisa conter até 500 caracteres");

            RuleFor(e => e.RespostaCandidato)
                .NotEmpty()
                .WithMessage("A resposta é obrigatória")
                .MaximumLength(250)
                .WithMessage("A descrição precisa conter até 250 caracteres");

            RuleFor(e => e.CodigoGrupoPergunta)
               .NotEmpty()
               .WithMessage("O código do grupo é obrigatório");

            RuleFor(e => e.DescricaoGrupoPergunta)
               .NotEmpty()
               .WithMessage("A descrição do grupo é obrigatória")
               .MaximumLength(45)
               .WithMessage("A descrição precisa conter até 45 caracteres");

            ValidationResult = Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
