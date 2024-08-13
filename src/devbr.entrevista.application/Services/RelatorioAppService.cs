using DevBr.Core.Aplicacao.Services;
using DevBr.Entrevista.Application.Interfaces.Applications;
using DevBr.Entrevista.Application.ViewsModels.Entrevistas;
using DevBr.Core.Dominio.Interfaces;
using AutoMapper;
using devbr.entrevista.domain.entities.relatorios;

namespace DevBr.Entrevista.Application.Services
{
    public class RelatorioAppService : AppServiceCore<RelatorioViewModel, Relatorio>, IRelatorioAppService
    {
        public RelatorioAppService(IServiceCore<Relatorio> service, IMapper mapper) : base(service, mapper)
        {

        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
