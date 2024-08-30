using AutoMapper;
using devbr.entrevista.domain.entities;
using DevBr.Core.Aplicacao.Services;
using DevBr.Core.Dominio.Interfaces;
using DevBr.Entrevista.Application.Interfaces.Applications;
using DevBr.Entrevista.Application.ViewsModels;

namespace DevBr.Entrevista.Application.Services
{
    public class LinguagemAppService : AppServiceCore<LinguagemViewModel, Linguagem>, ILinguagemAppService
    {
        public LinguagemAppService(IServiceCore<Linguagem> service, IMapper mapper, NotificationContext notification) : base(service, mapper, notification)
        {

        }

        public override IEnumerable<LinguagemViewModel> Listar()
        {
            var result = _service.Listar().ToList();
            return _mapper.Map<IEnumerable<LinguagemViewModel>>(result);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
