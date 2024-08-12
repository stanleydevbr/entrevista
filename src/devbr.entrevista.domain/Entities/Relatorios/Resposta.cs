using DevBr.Core.Dominio.Entidades;

namespace devbr.entrevista.domain.entities.relatorios
{
    public class Resposta : Entity<Resposta>
    {
        public string Pergunta { get; set; }
        public string RespostaCandidato { get; set; }
        public string RespostaEsperada { get; set; }
        public int CodigoGrupoPergunta { get; set; }
        public string DescricaoGrupoPergunta { get; set; }
        public NivelConhecimento NivelConhecimento { get; set; }
        public Guid NivelConhecimentoId { get; set; }
        public Relatorio Relatorio { get; set; }
        public Guid RelatorioId { get; set; }

        public override bool EhValido()
        {
            throw new NotImplementedException();
        }
    }
}
