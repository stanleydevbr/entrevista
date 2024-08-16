using DevBr.Core.Dominio.ViewModels;

namespace DevBr.Entrevista.Application.ViewsModels.Questionarios
{
    public class GrupoViewModel: ViewModelCore
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public GrupoViewModel()
        {
            Id = Guid.NewGuid();
        }
    }
}
