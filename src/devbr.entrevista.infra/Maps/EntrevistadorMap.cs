using devbr.entrevista.domain.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBr.Entrevista.Infra.Maps
{
    internal class EntrevistadorMap : IEntityTypeConfiguration<Entrevistador>
    {
        public void Configure(EntityTypeBuilder<Entrevistador> builder)
        {
            builder.ToTable("Entrevistadores");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(200); // Ajuste o tamanho conforme necessário

            builder.Property(e => e.Cliente)
                .IsRequired()
                .HasMaxLength(200); // Ajuste o tamanho conforme necessário

            builder.Property(e => e.Familia)
                .IsRequired()
                .HasMaxLength(200); // Ajuste o tamanho conforme necessário

            builder.Property(e => e.Nivel)
                .IsRequired()
                .HasMaxLength(100); // Ajuste o tamanho conforme necessário

            // Adicione outras configurações conforme necessário
        }
    }
}
