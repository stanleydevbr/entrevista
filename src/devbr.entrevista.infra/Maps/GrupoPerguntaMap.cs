using devbr.entrevista.domain.entities.questionarios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevBr.Entrevista.Infra.Maps
{
    internal class GrupoPerguntaMap : IEntityTypeConfiguration<GrupoPergunta>
    {
        public void Configure(EntityTypeBuilder<GrupoPergunta> builder)
        {
            builder.ToTable("GrupoPerguntas");

            builder.HasKey(gp => gp.Id);

            builder.Property(gp => gp.Codigo)
                .ValueGeneratedOnAdd();

            builder.Property(gp => gp.Descricao)
                   .IsRequired()
                   .HasMaxLength(255);

            builder.HasMany(gp => gp.Perguntas)
                   .WithOne()
                   .HasForeignKey("GrupoPerguntaId")
                   .OnDelete(DeleteBehavior.Cascade);

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
