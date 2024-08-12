using devbr.entrevista.domain.entities.relatorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBr.Entrevista.Infra.Maps
{
    internal class NivelConhecimentoMap : IEntityTypeConfiguration<NivelConhecimento>
    {
        public void Configure(EntityTypeBuilder<NivelConhecimento> builder)
        {
            builder.ToTable("NiveisConhecimento");

            builder.HasKey(nc => nc.Id);

            builder.Property(nc => nc.Descricao)
                .IsRequired()
                .HasMaxLength(200); // Ajuste o tamanho conforme necessário

            builder.Property(nc => nc.Valor)
                .IsRequired()
                .HasColumnType("decimal(18,2)"); // Ajuste o tipo conforme necessário

            // Adicione outras configurações conforme necessário
        }
    }
}
