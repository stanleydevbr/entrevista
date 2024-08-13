using devbr.entrevista.domain.entities;
using DevBr.Entrevista.Domain.Interfaces.Repositories;
using DevBr.Entrevista.Infra.Contents;

namespace DevBr.Entrevista.Infra.Repositories
{
    public class EntrevistadorRepository : BaseRepository<Entrevistador>, IEntrevistadorRepository
    {
        public EntrevistadorRepository(EntrevistaDbContent context) : base(context)
        {
        }
    }
}
