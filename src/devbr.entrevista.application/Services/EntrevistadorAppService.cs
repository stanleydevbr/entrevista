using DevBr.Core.Aplicacao.Services;
using DevBr.Entrevista.Application.Interfaces.Applications;
using DevBr.Core.Dominio.Interfaces;
using AutoMapper;
using devbr.entrevista.domain.entities;
using DevBr.Entrevista.Application.ViewsModels;

namespace DevBr.Entrevista.Application.Services
{
    public class EntrevistadorAppService : AppServiceCore<EntrevistadorViewModel, Entrevistador>, IEntrevistadorAppService
    {
        public EntrevistadorAppService(IServiceCore<Entrevistador> service, IMapper mapper) : base(service, mapper)
        {

        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
