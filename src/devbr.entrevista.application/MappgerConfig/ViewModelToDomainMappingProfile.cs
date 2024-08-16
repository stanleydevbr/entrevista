using AutoMapper;
using devbr.entrevista.domain.entities;
using devbr.entrevista.domain.entities.questionarios;
using devbr.entrevista.domain.entities.relatorios;
using DevBr.Entrevista.Application.ViewsModels;
using DevBr.Entrevista.Application.ViewsModels.Entrevistas;
using DevBr.Entrevista.Application.ViewsModels.Questionarios;

namespace DevBr.Entrevista.Application.MappgerConfig
{
    public class ViewModelToDomainMappingProfile: Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<EntrevistaViewModel, Entrevistar>();
            CreateMap<GrupoViewModel, GrupoPergunta>();
            CreateMap<PerguntaViewModel, Pergunta>();
            CreateMap<QuestionarioViewModel, Questionario>();
            CreateMap<NivelConhecimentoViewModel, NivelConhecimento>();
            CreateMap<RelatorioViewModel, Relatorio>();
            CreateMap<RespostaViewModel, Resposta>();
            CreateMap<LinguagemViewModel, Linguagem>();
            CreateMap<EntrevistadorViewModel, Entrevistador>();
            CreateMap<CandidatoViewModel, Candidato>();
        }
    }
}
