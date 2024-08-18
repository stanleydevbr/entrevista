using DevBr.Core.Dominio.Entidades;
using DevBr.Core.Dominio.Notificacoes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevBr.Core.Dominio.Interfaces
{
    public interface IServiceCore<TEntity>
    {
        Task<TEntity> AdicionarAsync(TEntity entity);
        Task<TEntity> EditarAsync(TEntity entity);
        Task<bool> ExcluirAsync(Guid id);
        Task<TEntity> ConsultarAsync(Guid id);
        Task<List<TEntity>> ListarAsync();
        Task<ResultList<TEntity>> ListarAsync(FilterList filtro);
        TEntity Adicionar(TEntity entity);
        TEntity Editar(TEntity entity);
        bool Excluir(Guid id);
        TEntity Consultar(Guid id);
        List<TEntity> Listar();
        ResultList<TEntity> Listar(FilterList filtro);

    }
}
