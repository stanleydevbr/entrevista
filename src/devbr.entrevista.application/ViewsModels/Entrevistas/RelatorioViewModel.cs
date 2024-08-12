namespace DevBr.Entrevista.Application.ViewsModels.Entrevistas
{
    public class RelatorioViewModel
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public string PontosFortes { get; set; }
        public string PontosFracos { get; set; }
        public string Observacao { get; set; }
        public string Resultado { get; set; }
        public EntrevistaViewModel Entrevista { get; set; }
    }
}
