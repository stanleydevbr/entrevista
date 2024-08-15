using devbr.entrevista.domain.entities.questionarios;
using DevBr.Entrevista.Domain.Interfaces.Repositories;
using DevBr.Entrevista.Infra.Contents;

namespace DevBr.Entrevista.Infra.Repositories
{
    public class GrupoPerguntaRepository : RepositoryCore<GrupoPergunta>, IGrupoPerguntaRepository
    {
        public GrupoPerguntaRepository(EntrevistaDbContent context) : base(context)
        {

        }

    }
}
