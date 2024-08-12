using devbr.entrevista.domain.entities.relatorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevBr.Entrevista.Infra.Maps
{
    internal class RespostaMap : IEntityTypeConfiguration<Resposta>
    {
        public void Configure(EntityTypeBuilder<Resposta> builder)
        {
            builder.ToTable("Respostas");

            builder.HasKey(r => r.Id);

            builder.Property(r => r.Pergunta)
                .IsRequired()
                .HasMaxLength(500); // Ajuste o tamanho conforme necessário

            builder.Property(l => l.Codigo)
                .IsRequired()
                .HasComputedColumnSql("NEXT VALUE FOR SequenciaRespostas");

            builder.Property(r => r.RespostaCandidato)
                .IsRequired()
                .HasMaxLength(250); 

            builder.Property(r => r.RespostaEsperada)
                .IsRequired()
                .HasColumnType("VARCHAR(MAX)");

            builder.Property(r => r.CodigoGrupoPergunta)
                .IsRequired();

            builder.Property(r => r.DescricaoGrupoPergunta)
                .IsRequired()
                .HasMaxLength(45); 

            builder.HasOne(e => e.NivelConhecimento)
                .WithMany(c => c.Respostas)
                .HasForeignKey(e => e.NivelConhecimentoId);

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
