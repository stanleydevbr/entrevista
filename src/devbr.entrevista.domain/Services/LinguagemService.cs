using devbr.entrevista.domain.entities;
using DevBr.Core.Dominio.Interfaces;
using DevBr.Core.Dominio.Services;
using DevBr.Entrevista.Domain.Interfaces.Services;

namespace DevBr.Entrevista.Domain.Services
{
    public class LinguagemService : ServiceCore<Linguagem>, ILinguagemService
    {
        public LinguagemService(IRepositoryCore<Linguagem> repository) : base(repository)
        {
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
