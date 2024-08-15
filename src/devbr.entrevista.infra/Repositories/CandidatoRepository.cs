using devbr.entrevista.domain.entities;
using DevBr.Entrevista.Domain.Interfaces.Repositories;
using DevBr.Entrevista.Infra.Contents;

namespace DevBr.Entrevista.Infra.Repositories
{
    public class CandidatoRepository : RepositoryCore<Candidato>, ICandidatoRepository
    {
        public CandidatoRepository(EntrevistaDbContent context) : base(context)
        {
        }
    }
}
