using devbr.entrevista.domain.entities.questionarios;
using DevBr.Entrevista.Domain.Interfaces.Repositories;
using DevBr.Entrevista.Infra.Contents;

namespace DevBr.Entrevista.Infra.Repositories
{
    public class GrupoPerguntaRepository : BaseRepository<GrupoPergunta>, IGrupoPerguntaRepository
    {
        public GrupoPerguntaRepository(EntrevistaDbContent context) : base(context)
        {

        }

    }
}
