using DevBr.Core.Dominio.Entidades;

namespace devbr.entrevista.domain.entities.relatorios
{
    public class Relatorio : Entity<Relatorio>
    {
        public string Descricao { get; set; }
        public string PontosFortes { get; set; }
        public string PontosFracos { get; set; }
        public string Observacao { get; set; }
        public string Resultado { get; set; }
        public Entrevista Entrevista { get; set; }
        public Guid EntrevistaId { get; set; }
        public override bool EhValido()
        {
            throw new NotImplementedException();
        }
    }
}
