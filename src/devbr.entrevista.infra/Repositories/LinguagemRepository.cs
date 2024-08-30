using devbr.entrevista.domain.entities;
using DevBr.Entrevista.Domain.Interfaces.Repositories;
using DevBr.Entrevista.Infra.Contents;

namespace DevBr.Entrevista.Infra.Repositories
{
    public class LinguagemRepository : RepositoryCore<Linguagem>, ILinguagemRepository
    {
        public LinguagemRepository(EntrevistaDbContent context) : base(context)
        {

        }
    }
}
