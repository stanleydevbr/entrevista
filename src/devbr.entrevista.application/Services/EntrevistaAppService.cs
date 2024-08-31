using DevBr.Core.Aplicacao.Services;
using DevBr.Entrevista.Application.Interfaces.Applications;
using DevBr.Entrevista.Application.ViewsModels.Entrevistas;
using DevBr.Core.Dominio.Interfaces;
using AutoMapper;
using devbr.entrevista.domain.entities;
using DevBr.Entrevista.Application.ViewsModels;

namespace DevBr.Entrevista.Application.Services
{
    public class EntrevistaAppService : AppServiceCore<EntrevistaViewModel, Entrevistar>, IEntrevistaAppService
    {
        public EntrevistaAppService(IServiceCore<Entrevistar> service, IMapper mapper, NotificationContext notification) : base(service, mapper, notification)
        {

        }

        public override IEnumerable<EntrevistaViewModel> Listar()
        {
            var result = _service.Listar().ToList();
            return _mapper.Map<IEnumerable<EntrevistaViewModel>>(result);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
