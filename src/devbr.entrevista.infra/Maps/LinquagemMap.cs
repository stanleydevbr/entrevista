using devbr.entrevista.domain.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevBr.Entrevista.Infra.Maps
{
    internal class LinquagemMap : IEntityTypeConfiguration<Linguagem>
    {
        public void Configure(EntityTypeBuilder<Linguagem> builder)
        {
            builder.ToTable("Linguagens");

            builder.HasKey(l => l.Id);

            builder.Property(l => l.Codigo)
                .ValueGeneratedOnAdd();

            builder.Property(l => l.Descricao)
                .IsRequired()
                .HasMaxLength(45);

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
