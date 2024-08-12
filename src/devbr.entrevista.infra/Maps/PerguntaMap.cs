using devbr.entrevista.domain.entities.questionarios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevBr.Entrevista.Infra.Maps
{
    internal class PerguntaMap : IEntityTypeConfiguration<Pergunta>
    {
        public void Configure(EntityTypeBuilder<Pergunta> builder)
        {
            builder.ToTable("Perguntas");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(p => p.Resposta)
                .HasMaxLength(1000);

            builder.Property(p => p.Status)
                .IsRequired();

            builder.HasOne(p => p.GrupoPergunta)
                .WithMany(g => g.Perguntas)
                .HasForeignKey(p => p.GrupoPerguntaId);

            builder.Property(p => p.GrupoPerguntaId)
                .IsRequired();
        }
    }
}
