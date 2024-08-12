using devbr.entrevista.domain.entities.questionarios;
using DevBr.Entrevista.Domain.Interfaces.Repositories;
using DevBr.Entrevista.Infra.Contents;

namespace DevBr.Entrevista.Infra.Repositories
{
    public class QuestionarioRepository : BaseRepository<Questionario>, IQuestionarioRepository
    {
        public QuestionarioRepository(EntrevistaDbContent context) : base(context)
        {
        }
    }
}
