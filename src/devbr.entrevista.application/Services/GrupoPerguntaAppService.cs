using DevBr.Core.Aplicacao.Services;
using DevBr.Entrevista.Application.Interfaces.Applications;
using DevBr.Core.Dominio.Interfaces;
using AutoMapper;
using devbr.entrevista.domain.entities.questionarios;
using DevBr.Entrevista.Application.ViewsModels.Questionarios;
using DevBr.Entrevista.Application.ViewsModels;

namespace DevBr.Entrevista.Application.Services
{
    public class GrupoPerguntaAppService : AppServiceCore<GrupoViewModel, GrupoPergunta>, IGrupoPerguntaAppService
    {
        public GrupoPerguntaAppService(IServiceCore<GrupoPergunta> service, IMapper mapper, NotificationContext notification) : base(service, mapper, notification)
        {

        }

        public override IEnumerable<GrupoViewModel> Listar()
        {
            var result = _service.Listar().ToList();
            return _mapper.Map<IEnumerable<GrupoViewModel>>(result);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
