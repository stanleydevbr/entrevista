using devbr.entrevista.domain.entities.relatorios;
using DevBr.Core.Dominio.Interfaces;
using DevBr.Core.Dominio.Services;
using DevBr.Entrevista.Domain.Interfaces.Services;

namespace DevBr.Entrevista.Domain.Services
{
    public class RelatorioService : ServiceCore<Relatorio>, IRelatorioService
    {
        public RelatorioService(IRepositoryCore<Relatorio> repository) : base(repository)
        {

        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
