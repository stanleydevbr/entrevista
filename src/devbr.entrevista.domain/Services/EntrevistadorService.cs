using devbr.entrevista.domain.entities;
using DevBr.Core.Dominio.Interfaces;
using DevBr.Core.Dominio.Services;
using DevBr.Entrevista.Domain.Interfaces.Services;

namespace DevBr.Entrevista.Domain.Services
{
    public class EntrevistadorService : ServiceCore<Entrevistador>, IEntrevistadorService
    {
        public EntrevistadorService(IRepositoryCore<Entrevistador> repository) : base(repository)
        {
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
