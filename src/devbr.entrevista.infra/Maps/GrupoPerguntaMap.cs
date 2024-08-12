using devbr.entrevista.domain.entities.questionarios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevBr.Entrevista.Infra.Maps
{
    internal class GrupoPerguntaMap : IEntityTypeConfiguration<GrupoPergunta>
    {
        public void Configure(EntityTypeBuilder<GrupoPergunta> builder)
        {
            builder.ToTable("GruposPerguntas");

            builder.HasKey(gp => gp.Id);

            builder.Property(gp => gp.Descricao)
                .IsRequired()
                .HasMaxLength(500); // Ajuste o tamanho conforme necessário

            // Adicione outras configurações conforme necessário
        }
    }
}
