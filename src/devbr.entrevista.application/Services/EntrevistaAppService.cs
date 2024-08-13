using DevBr.Core.Aplicacao.Services;
using DevBr.Entrevista.Application.Interfaces.Applications;
using DevBr.Entrevista.Application.ViewsModels.Entrevistas;
using DevBr.Core.Dominio.Interfaces;
using AutoMapper;

namespace DevBr.Entrevista.Application.Services
{
    public class EntrevistaAppService : AppServiceCore<EntrevistaViewModel, devbr.entrevista.domain.entities.Entrevista>, IEntrevistaAppService
    {
        public EntrevistaAppService(IServiceCore<devbr.entrevista.domain.entities.Entrevista> service, IMapper mapper) : base(service, mapper)
        {

        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
