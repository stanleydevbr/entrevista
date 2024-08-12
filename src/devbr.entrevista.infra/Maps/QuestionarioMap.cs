using devbr.entrevista.domain.entities.questionarios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevBr.Entrevista.Infra.Maps
{
    internal class QuestionarioMap : IEntityTypeConfiguration<Questionario>
    {
        public void Configure(EntityTypeBuilder<Questionario> builder)
        {
            builder.ToTable("Questionarios");

            builder.HasKey(q => q.Id);

            builder.Property(q => q.Nome)
                .IsRequired()
                .HasMaxLength(200); // Ajuste o tamanho conforme necessário

            builder.Property(q => q.Descricao)
                .IsRequired()
                .HasMaxLength(1000); // Ajuste o tamanho conforme necessário

            builder.Property(q => q.Status)
                .IsRequired();

            // Adicione outras configurações conforme necessário
        }
    }
}
