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
                   .HasColumnType("varchar(max)");


            builder.Property(p => p.Status)
                   .IsRequired();

            builder.HasOne(p => p.GrupoPergunta)
                   .WithMany(gp => gp.Perguntas)
                   .HasForeignKey(p => p.GrupoPerguntaId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(p => p.Questionarios)
                   .WithMany(q => q.Perguntas)
                   .UsingEntity(j => j.ToTable("PerguntaQuestionario"));

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
