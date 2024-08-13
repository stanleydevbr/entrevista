using DevBr.Core.Aplicacao.Interfaces;
using DevBr.Entrevista.Application.ViewsModels;
using DevBr.Entrevista.Application.ViewsModels.Entrevistas;

namespace DevBr.Entrevista.Application.Interfaces.Applications
{
    public interface IEntrevistaAppService : IDisposable, IAppServiceCore<EntrevistaViewModel>
    {
    }
}
