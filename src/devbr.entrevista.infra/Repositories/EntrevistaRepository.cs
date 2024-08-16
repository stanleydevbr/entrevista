using DevBr.Entrevista.Domain.Interfaces.Repositories;
using DevBr.Entrevista.Infra.Contents;

namespace DevBr.Entrevista.Infra.Repositories
{
    public class EntrevistaRepository : RepositoryCore<devbr.entrevista.domain.entities.Entrevistar>, IEntrevistaRepository
    {
        public EntrevistaRepository(EntrevistaDbContent context) : base(context)
        {
        }
    }
}
