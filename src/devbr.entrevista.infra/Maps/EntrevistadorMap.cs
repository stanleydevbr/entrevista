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

            builder.Property(e => e.Codigo)
                .IsRequired()
                .HasComputedColumnSql("NEXT VALUE FOR SequenciaEntrevistador");                

            builder.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(80); 

            builder.Property(e => e.Cliente)
                .IsRequired()
                .HasMaxLength(100); 

            builder.Property(e => e.Familia)
                .IsRequired()
                .HasMaxLength(30); 

            builder.Property(e => e.Nivel)
                .IsRequired()
                .HasMaxLength(3); 

            builder.Property(c => c.UsuarioCriacao)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(c => c.DataCriacao)
                .IsRequired();

            builder.Property(c => c.UsuarioAlteracao)
                .HasMaxLength(10);

            builder.Property(c => c.DataAlteracao);

            builder.HasMany(e => e.Linguagens)
                     .WithMany(l => l.Entrevistadores)
                     .UsingEntity<Dictionary<string, object>>(
                         "EntrevistadorLinguagem",
                         j => j.HasOne<Linguagem>().WithMany().HasForeignKey("LinguagemId"),
                         j => j.HasOne<Entrevistador>().WithMany().HasForeignKey("EntrevistadorId")
                     );
        }
    }
}
