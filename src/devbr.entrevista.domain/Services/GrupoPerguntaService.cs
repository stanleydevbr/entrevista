using devbr.entrevista.domain.entities.questionarios;
using DevBr.Core.Dominio.Interfaces;
using DevBr.Core.Dominio.Services;
using DevBr.Entrevista.Domain.Interfaces.Services;

namespace DevBr.Entrevista.Domain.Services
{
    public class GrupoPerguntaService : ServiceCore<GrupoPergunta>, IGrupoPerguntaService
    {
        public GrupoPerguntaService(IRepositoryCore<GrupoPergunta> repository) : base(repository)
        {

        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
