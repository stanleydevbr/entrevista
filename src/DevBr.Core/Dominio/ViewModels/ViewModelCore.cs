using System;

namespace DevBr.Core.Dominio.ViewModels
{
    public abstract class ViewModelCore : BaseViewModel
    {
        public Guid Id { get; set; }
        public long Codigo { get; set; }
        public string UsuarioCriacao { get; set; }
        public string UsuarioAlteracao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataAlteracao { get; set; }
    }
}
