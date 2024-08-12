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
    internal class LinquagemMap : IEntityTypeConfiguration<Linguagem>
    {
        public void Configure(EntityTypeBuilder<Linguagem> builder)
        {
            builder.ToTable("Linguagens");

            builder.HasKey(l => l.Id);

            builder.Property(l => l.Descricao)
                .IsRequired()
                .HasMaxLength(200); // Ajuste o tamanho conforme necessário

            // Adicione outras configurações conforme necessário
        }
    }
}
