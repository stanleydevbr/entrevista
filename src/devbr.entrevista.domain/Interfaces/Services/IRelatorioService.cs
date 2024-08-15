using DevBr.Core.Dominio.Interfaces;
using devbr.entrevista.domain.entities;
using devbr.entrevista.domain.entities.relatorios;

namespace DevBr.Entrevista.Domain.Interfaces.Services
{
    public interface IRelatorioService : IServiceCore<Relatorio>, IDisposable
    {
    }
}
