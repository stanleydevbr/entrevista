using DevBr.Core.Dominio.Interfaces;
using DevBr.Core.Dominio.Services;
using DevBr.Entrevista.Domain.Interfaces.Services;

namespace DevBr.Entrevista.Domain.Services
{
    public class EntrevistaService : ServiceCore<devbr.entrevista.domain.entities.Entrevistar>, IEntrevistaService
    {
        public EntrevistaService(IRepositoryCore<devbr.entrevista.domain.entities.Entrevistar> repository) : base(repository) 
        {
            
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
