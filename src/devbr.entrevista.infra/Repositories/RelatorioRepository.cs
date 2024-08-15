using devbr.entrevista.domain.entities.relatorios;
using DevBr.Entrevista.Domain.Interfaces.Repositories;
using DevBr.Entrevista.Infra.Contents;

namespace DevBr.Entrevista.Infra.Repositories
{
    public class RelatorioRepository : RepositoryCore<Relatorio>, IRelatorioRepository
    {
        public RelatorioRepository(EntrevistaDbContent context) : base(context)
        {

        }
    }
}
