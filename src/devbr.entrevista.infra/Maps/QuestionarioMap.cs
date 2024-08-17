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

            builder.Property(q => q.Codigo)
                .ValueGeneratedOnAdd();

            builder.Property(q => q.Nome)
                .IsRequired()
                .HasMaxLength(45);

            builder.Property(q => q.Descricao)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(q => q.Status)
                .IsRequired();

            builder.Property(c => c.UsuarioCriacao)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(c => c.DataCriacao)
                .IsRequired();

            builder.Property(c => c.UsuarioAlteracao)
                .HasMaxLength(10);

            builder.Property(c => c.DataAlteracao);


            builder.HasMany(q => q.Perguntas)
                   .WithMany(p => p.Questionarios)
                   .UsingEntity(j => j.ToTable("PerguntaQuestionario"));

            builder.Ignore(x => x.ValidationResult);
            builder.Ignore(x => x.CascadeMode);

        }
    }
}
