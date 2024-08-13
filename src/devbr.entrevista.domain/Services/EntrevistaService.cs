using DevBr.Core.Dominio.Interfaces;
using DevBr.Core.Dominio.Services;
using DevBr.Entrevista.Domain.Interfaces.Services;

namespace DevBr.Entrevista.Domain.Services
{
    public class EntrevistaService : ServiceCore<devbr.entrevista.domain.entities.Entrevista>, IEntrevistaService
    {
        public EntrevistaService(IRepositoryCore<devbr.entrevista.domain.entities.Entrevista> repository) : base(repository) 
        {
            
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
