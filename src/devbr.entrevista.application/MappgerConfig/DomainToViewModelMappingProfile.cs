using AutoMapper;
using devbr.entrevista.domain.entities;
using devbr.entrevista.domain.entities.questionarios;
using devbr.entrevista.domain.entities.relatorios;
using DevBr.Entrevista.Application.ViewsModels;
using DevBr.Entrevista.Application.ViewsModels.Entrevistas;
using DevBr.Entrevista.Application.ViewsModels.Questionarios;

namespace DevBr.Entrevista.Application.MappgerConfig
{
    public class DomainToViewModelMappingProfile: Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Entrevistar, EntrevistaViewModel>();
            CreateMap<Entrevistador, EntrevistadorViewModel>();
            CreateMap<Questionario, QuestionarioViewModel>();
            CreateMap<Relatorio, RelatorioViewModel>();
            CreateMap<Resposta, RespostaViewModel>();
            CreateMap<Candidato, CandidatoViewModel>();
            CreateMap<GrupoPergunta, GrupoViewModel>();
            CreateMap<Pergunta, PerguntaViewModel>();
            CreateMap<Linguagem, LinguagemViewModel>();
            CreateMap<NivelConhecimento, NivelConhecimentoViewModel>();

        }
    }
}
