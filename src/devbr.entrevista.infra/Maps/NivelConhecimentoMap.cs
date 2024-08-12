using devbr.entrevista.domain.entities.relatorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevBr.Entrevista.Infra.Maps
{
    internal class NivelConhecimentoMap : IEntityTypeConfiguration<NivelConhecimento>
    {
        public void Configure(EntityTypeBuilder<NivelConhecimento> builder)
        {
            builder.ToTable("NiveisConhecimento");

            builder.HasKey(nc => nc.Id);

            builder.Property(nc => nc.Codigo)
                .IsRequired()
                .HasComputedColumnSql("NEXT VALUE FOR SequenciaNiveisConhecimento");

            builder.Property(nc => nc.Descricao)
                .IsRequired()
                .HasMaxLength(45); 

            builder.Property(nc => nc.Valor)
                .IsRequired()
                .HasColumnType("decimal(18,2)"); 

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
