using DevBr.Core.Aplicacao.Services;
using DevBr.Entrevista.Application.Interfaces.Applications;
using DevBr.Core.Dominio.Interfaces;
using AutoMapper;
using devbr.entrevista.domain.entities;
using DevBr.Entrevista.Application.ViewsModels;
using DevBr.Entrevista.Application.ViewsModels.Entrevistas;

namespace DevBr.Entrevista.Application.Services
{
    public class EntrevistadorAppService : AppServiceCore<EntrevistadorViewModel, Entrevistador>, IEntrevistadorAppService
    {
        public EntrevistadorAppService(IServiceCore<Entrevistador> service, IMapper mapper, NotificationContext notification) : base(service, mapper, notification)
        {

        }
        public override IEnumerable<EntrevistadorViewModel> Listar()
        {
            var result = _service.Listar().ToList();
            return _mapper.Map<IEnumerable<EntrevistadorViewModel>>(result);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
