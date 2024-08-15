using devbr.entrevista.domain.entities.questionarios;
using DevBr.Entrevista.Domain.Interfaces.Repositories;
using DevBr.Entrevista.Infra.Contents;

namespace DevBr.Entrevista.Infra.Repositories
{
    public class PerguntaRepository : RepositoryCore<Pergunta>, IPerguntaRepository
    {
        public PerguntaRepository(EntrevistaDbContent context) : base(context)
        {
        }
    }
}
