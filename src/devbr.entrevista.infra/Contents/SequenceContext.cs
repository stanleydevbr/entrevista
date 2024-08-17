using Microsoft.EntityFrameworkCore;

namespace DevBr.Entrevista.Infra.Contents
{
    internal static class SequenceContext
    {
        internal static ModelBuilder AddSequence(this ModelBuilder modelBuilder)
        {
            modelBuilder.HasSequence<long>("SequenciaCandidato", "dbo").StartsAt(1).IncrementsBy(1);
            modelBuilder.HasSequence<long>("SequenciaEntrevistador", "dbo").StartsAt(1).IncrementsBy(1);
            modelBuilder.HasSequence<long>("SequenciaEntrevista", "dbo").StartsAt(1).IncrementsBy(1);
            modelBuilder.HasSequence<long>("SequenciaGrupoPergunta", "dbo").StartsAt(1).IncrementsBy(1);
            modelBuilder.HasSequence<long>("SequenciaLinguagem", "dbo").StartsAt(1).IncrementsBy(1);
            modelBuilder.HasSequence<long>("SequenciaNivelConhecimento", "dbo").StartsAt(1).IncrementsBy(1);
            modelBuilder.HasSequence<long>("SequenciaPergunta", "dbo").StartsAt(1).IncrementsBy(1);
            modelBuilder.HasSequence<long>("SequenciaQuestionario", "dbo").StartsAt(1).IncrementsBy(1);
            modelBuilder.HasSequence<long>("SequenciaRelatorio", "dbo").StartsAt(1).IncrementsBy(1);
            modelBuilder.HasSequence<long>("SequenciaResposta", "dbo").StartsAt(1).IncrementsBy(1);

            return modelBuilder;
        }
    }
}
