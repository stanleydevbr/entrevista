using devbr.entrevista.domain.entities.relatorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevBr.Entrevista.Infra.Maps
{
    internal class RelatorioMap : IEntityTypeConfiguration<Relatorio>
    {
        public void Configure(EntityTypeBuilder<Relatorio> builder)
        {
            builder.ToTable("Relatorios");

            builder.HasKey(r => r.Id);

            builder.Property(r => r.Codigo)
                   .IsRequired()
                   .HasComputedColumnSql("NEXT VALUE FOR SequenciaRelatorio");

            builder.Property(r => r.Descricao)
                   .IsRequired()
                   .HasMaxLength(80);

            builder.Property(r => r.PontosFortes)
                   .HasMaxLength(800);

            builder.Property(r => r.PontosFracos)
                   .HasMaxLength(800);

            builder.Property(r => r.Observacao)
                   .HasMaxLength(800);

            builder.Property(r => r.Resultado)
                   .HasMaxLength(45);

            builder.HasOne(r => r.Entrevista)
                   .WithMany(e => e.Relatorios)
                   .HasForeignKey(r => r.EntrevistaId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(r => r.Questionarios)
                   .WithMany(q => q.Relatorios)
                   .UsingEntity(j => j.ToTable("RelatorioQuestionario"));

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
