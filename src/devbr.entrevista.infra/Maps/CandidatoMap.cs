using devbr.entrevista.domain.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevBr.Entrevista.Infra.Maps
{
    internal class CandidatoMap : IEntityTypeConfiguration<Candidato>
    {
        public void Configure(EntityTypeBuilder<Candidato> builder)
        {
            builder.ToTable("Candidatos");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Codigo)
                .ValueGeneratedOnAdd();

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(80);

            builder.Property(c => c.UsuarioCriacao)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(c => c.DataCriacao)
                .IsRequired();

            builder.Property(c => c.UsuarioAlteracao)
                .HasMaxLength(10);

            builder.Property(c => c.DataAlteracao);

            builder.Ignore(x => x.ValidationResult);
            builder.Ignore(x => x.CascadeMode);
        }
    }
}
