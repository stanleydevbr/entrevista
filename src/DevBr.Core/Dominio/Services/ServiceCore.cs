using DevBr.Core.Dominio.Entidades;
using DevBr.Core.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevBr.Core.Dominio.Services
{
    public class ServiceCore<TEntity> : IServiceCore<TEntity>
    {
        public readonly IRepositoryCore<TEntity> _repository;

        public ServiceCore(IRepositoryCore<TEntity> repository)
        {
            this._repository = repository;
        }

        public virtual TEntity Adicionar(TEntity entity)
        {
            return _repository.Adicionar(entity);
        }

        public virtual async Task<TEntity> AdicionarAsync(TEntity entity)
        {
            return await _repository.AdicionarAsync(entity);
        }

        public virtual TEntity Consultar(Guid id)
        {
            return _repository.ObterPorId(id);
        }

        public virtual async Task<TEntity> ConsultarAsync(Guid id)
        {
            return await _repository.ObterPorIdAsync(id);
        }

        public virtual TEntity Editar(TEntity entity)
        {
            return _repository.Atualizar(entity);
        }

        public virtual async Task<TEntity> EditarAsync(TEntity entity)
        {   
            return await _repository.AtualizarAsync(entity);
        }

        public virtual bool Excluir(Guid id)
        {
            return _repository.Remover(id);
        }

        public virtual async Task<bool> ExcluirAsync(Guid id)
        {
            return await _repository.RemoverAsync(id);
        }

        public virtual List<TEntity> Listar()
        {
            return _repository.ObterTodos().ToList();
        }

        public virtual ResultList<TEntity> Listar(FilterList filtro)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<List<TEntity>> ListarAsync()
        {
            return await _repository.ObterTodosAsync() as List<TEntity>;
        }

        public virtual Task<ResultList<TEntity>> ListarAsync(FilterList filtro)
        {
            throw new NotImplementedException();
        }
    }
}
