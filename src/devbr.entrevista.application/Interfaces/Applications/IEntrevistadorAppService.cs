using DevBr.Core.Aplicacao.Interfaces;
using DevBr.Entrevista.Application.ViewsModels;

namespace DevBr.Entrevista.Application.Interfaces.Applications
{
    public interface IEntrevistadorAppService : IDisposable, IAppServiceCore<EntrevistadorViewModel>
    {
    }
}
