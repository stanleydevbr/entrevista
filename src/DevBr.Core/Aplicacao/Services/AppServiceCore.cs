using AutoMapper;
using DevBr.Core.Aplicacao.Interfaces;
using DevBr.Core.Dominio.Entidades;
using DevBr.Core.Dominio.Interfaces;
using DevBr.Core.Dominio.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevBr.Core.Aplicacao.Services
{
    public class AppServiceCore<TViewModel, TEntity> : IAppServiceCore<TViewModel>
             where TViewModel : ViewModelCore
             where TEntity : Entity<TEntity>
    {
        public readonly IServiceCore<TEntity> _service;
        public readonly IMapper _mapper;
        public readonly NotificationContext _notification;
        public AppServiceCore(IServiceCore<TEntity> service, IMapper mapper, NotificationContext notification)
        {
            this._service = service;
            this._mapper = mapper;
            this._notification = notification;
        }

        public virtual TViewModel Adicionar(TViewModel viewModel)
        {
            var entity = _mapper.Map<TEntity>(viewModel);
            if (EntidadeValida(entity))
                return TrateRetorno(this._service.Adicionar(entity));

            return TrateRetorno(entity);
        }

        public virtual async Task<TViewModel> AdicionarAsync(TViewModel viewModel)
        {
            var entity = _mapper.Map<TEntity>(viewModel);

            return TrateRetorno(await this._service.AdicionarAsync(entity));
        }

        public virtual TViewModel Consultar(Guid id)
        {
            var result = this._service.Consultar(id);
            return _mapper.Map<TViewModel>(result);
        }

        public async Task<TViewModel> ConsultarAsync(Guid id)
        {
            var result = await this._service.ConsultarAsync(id);
            return _mapper.Map<TViewModel>(result);
        }

        public virtual TViewModel Editar(TViewModel viewModel)
        {
            var entity = _mapper.Map<TEntity>(viewModel);
            if (EntidadeValida(entity))
                return TrateRetorno(this._service.Editar(entity));

            return TrateRetorno(entity);
        }

        public virtual async Task<TViewModel> EditarAsync(TViewModel viewModel)
        {
            var entity = _mapper.Map<TEntity>(viewModel);
            if (EntidadeValida(entity))
                return TrateRetorno(await this._service.EditarAsync(entity));

            return TrateRetorno(entity);
        }

        public virtual bool Excluir(Guid id)
        {
            var result = this._service.Excluir(id);
            return result;
        }

        public virtual async Task<bool> ExcluirAsync(Guid id)
        {
            var result = await this._service.ExcluirAsync(id);
            return result;
        }

        public virtual IEnumerable<TViewModel> Listar()
        {
            var result = _service.Listar();
            return _mapper.Map<IEnumerable<TViewModel>>(result).ToList();
        }

        public virtual async Task<List<TViewModel>> ListarAsync()
        {
            var result = await _service.ListarAsync();
            return _mapper.Map<List<TViewModel>>(result);
        }

        public virtual async Task<ResultList<TViewModel>> ListarAsync(FilterList filtro)
        {
            var filtroMapped = _mapper.Map<FilterList>(filtro);
            var result = await this._service.ListarAsync(filtroMapped);
            return _mapper.Map<ResultList<TViewModel>>(result);
        }

        protected virtual TViewModel TrateRetorno(TEntity entity)
        {
            var resultado = _mapper.Map<TViewModel>(entity);
            return resultado;
        }
        protected virtual bool EntidadeValida(TEntity entity)
        {
            if (!entity.EhValido())
            {
                _notification.AddNotifications(entity.ValidationResult);
                return false;
            }
            return true;
        }
    }
}
