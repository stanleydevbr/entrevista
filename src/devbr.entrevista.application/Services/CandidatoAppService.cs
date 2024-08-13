using AutoMapper;
using devbr.entrevista.domain.entities;
using DevBr.Core.Aplicacao.Services;
using DevBr.Core.Dominio.Interfaces;
using DevBr.Entrevista.Application.Interfaces.Applications;
using DevBr.Entrevista.Application.ViewsModels;

namespace DevBr.Entrevista.Application.Services
{
    public class CandidatoAppService : AppServiceCore<CandidatoViewModel, Candidato>, ICandidatoAppService
    {
        public CandidatoAppService(IServiceCore<Candidato> service, IMapper mapper) : base(service, mapper)
        {
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
