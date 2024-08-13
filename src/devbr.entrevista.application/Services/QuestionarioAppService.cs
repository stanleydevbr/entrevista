using DevBr.Core.Aplicacao.Services;
using DevBr.Entrevista.Application.Interfaces.Applications;
using DevBr.Core.Dominio.Interfaces;
using AutoMapper;
using devbr.entrevista.domain.entities.questionarios;
using DevBr.Entrevista.Application.ViewsModels.Questionarios;

namespace DevBr.Entrevista.Application.Services
{
    public class QuestionarioAppService : AppServiceCore<QuestionarioViewModel, Questionario>, IQuestionarioAppService
    {
        public QuestionarioAppService(IServiceCore<Questionario> service, IMapper mapper) : base(service, mapper)
        {

        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
