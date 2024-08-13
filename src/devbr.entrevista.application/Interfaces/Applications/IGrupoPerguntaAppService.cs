using DevBr.Core.Aplicacao.Interfaces;
using DevBr.Entrevista.Application.ViewsModels;
using DevBr.Entrevista.Application.ViewsModels.Questionarios;

namespace DevBr.Entrevista.Application.Interfaces.Applications
{
    public interface IGrupoPerguntaAppService : IDisposable, IAppServiceCore<GrupoViewModel>
    {
    }
}
