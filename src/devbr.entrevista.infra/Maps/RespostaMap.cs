using devbr.entrevista.domain.entities.relatorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevBr.Entrevista.Infra.Maps
{
    internal class RespostaMap : IEntityTypeConfiguration<Resposta>
    {
        public void Configure(EntityTypeBuilder<Resposta> builder)
        {
            builder.ToTable("Respostas");

            builder.HasKey(r => r.Id);

            builder.Property(r => r.Pergunta)
                .IsRequired()
                .HasMaxLength(500); // Ajuste o tamanho conforme necessário

            builder.Property(r => r.RespostaCandidato)
                .IsRequired()
                .HasMaxLength(1000); // Ajuste o tamanho conforme necessário

            builder.Property(r => r.CodigoGrupoPergunta)
                .IsRequired();

            builder.Property(r => r.DescricaoGrupoPergunta)
                .IsRequired()
                .HasMaxLength(500); // Ajuste o tamanho conforme necessário

            // Adicione outras configurações conforme necessário
        }
    }
}
