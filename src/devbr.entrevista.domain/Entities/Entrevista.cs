using devbr.entrevista.domain.entities.relatorios;
using DevBr.Core.Dominio.Entidades;
using FluentValidation;

namespace devbr.entrevista.domain.entities
{
    public class Entrevistar : Entity<Entrevistar>
    {
        public Entrevistar()
        {
            Id = Guid.NewGuid();
        }
        public DateTime DataEntrevista { get; set; }
        public string NivelEsperado { get; set; }
        public Guid CandidatoId { get; set; }
        public virtual Candidato Candidato { get; set; } 
        public virtual ICollection<Entrevistador>? Entrevistadores { get; set; } 
        public virtual ICollection<Relatorio>? Relatorios { get; set; } 
        public Guid RelatorioId { get; set; }


        public override bool EhValido()
        {
            RuleFor(e => e.DataEntrevista)
                .NotEmpty()
                .WithMessage("A data da entrevista é obrigatória.");

            RuleFor(e => e.NivelEsperado)
                .NotEmpty()
                .WithMessage("O nível esperado é obrigatório.")
                .MaximumLength(3)
                .WithMessage("O nível esperado deve ter no máximo 3 caracteres.");

            RuleFor(e => e.CandidatoId)
                .NotEmpty()
                .WithMessage("O candidato é obrigatório.");

            ValidationResult = Validate(this);

            return ValidationResult.IsValid;
        }
    }
}
