using DevBr.Core.Aplicacao.Services;
using DevBr.Entrevista.Application.Interfaces.Applications;
using DevBr.Entrevista.Application.ViewsModels.Entrevistas;
using DevBr.Core.Dominio.Interfaces;
using AutoMapper;
using devbr.entrevista.domain.entities.relatorios;
using DevBr.Entrevista.Application.ViewsModels.Questionarios;

namespace DevBr.Entrevista.Application.Services
{
    public class RelatorioAppService : AppServiceCore<RelatorioViewModel, Relatorio>, IRelatorioAppService
    {
        public RelatorioAppService(IServiceCore<Relatorio> service, IMapper mapper, NotificationContext notification) : base(service, mapper, notification)
        {

        }

        
        public override IEnumerable<RelatorioViewModel> Listar()
        {
            var result = _service.Listar().ToList();
            return _mapper.Map<IEnumerable<RelatorioViewModel>>(result);
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
