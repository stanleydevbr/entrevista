using DevBr.Core.Dominio.Entidades;

namespace devbr.entrevista.domain.entities.relatorios
{
    public class NivelConhecimento : Entity<NivelConhecimento>
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }

        public List<Resposta> Respostas { get; set; }
        public override bool EhValido()
        {
            throw new NotImplementedException();
        }
    }
}
