using devbr.entrevista.domain.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevBr.Entrevista.Infra.Maps
{
    internal class EntrevistaMap : IEntityTypeConfiguration<devbr.entrevista.domain.entities.Entrevista>
    {
        public void Configure(EntityTypeBuilder<devbr.entrevista.domain.entities.Entrevista> builder)
        {
            builder.ToTable("Entrevistas");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Codigo)
                .IsRequired()
                .HasComputedColumnSql("NEXT VALUE FOR SequenciaEntrevista");            

            builder.Property(e => e.DataEntrevista)
                .IsRequired();

            builder.Property(e => e.NivelEsperado)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.CandidatoId)
                .IsRequired();

            builder.HasOne(e => e.Candidato)
                .WithMany(c => c.Entrevistas)
                .HasForeignKey(e => e.CandidatoId);

            builder.HasMany(e => e.Entrevistadores)
                .WithMany(e => e.Entrevistas)
                .UsingEntity<Dictionary<string, object>>(
                    "EntrevistaEntrevistador",
                    j => j.HasOne<Entrevistador>()
                          .WithMany()
                          .HasForeignKey("EntrevistadorId"),
                    j => j.HasOne<devbr.entrevista.domain.entities.Entrevista>()
                          .WithMany()
                          .HasForeignKey("EntrevistaId")
                );

            builder.Property(c => c.UsuarioCriacao)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(c => c.DataCriacao)
                .IsRequired();

            builder.Property(c => c.UsuarioAlteracao)
                .HasMaxLength(10);

            builder.Property(c => c.DataAlteracao);
        }
    }
}
