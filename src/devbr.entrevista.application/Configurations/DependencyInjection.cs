using AutoMapper;
using devbr.entrevista.domain.entities;
using devbr.entrevista.domain.entities.questionarios;
using devbr.entrevista.domain.entities.relatorios;
using DevBr.Core.Aplicacao.Interfaces;
using DevBr.Core.Aplicacao.Services;
using DevBr.Core.Dominio.Interfaces;
using DevBr.Core.Dominio.Services;
using DevBr.Entrevista.Application.Interfaces.Applications;
using DevBr.Entrevista.Application.MappgerConfig;
using DevBr.Entrevista.Application.Services;
using DevBr.Entrevista.Application.ViewsModels;
using DevBr.Entrevista.Application.ViewsModels.Entrevistas;
using DevBr.Entrevista.Application.ViewsModels.Questionarios;
using DevBr.Entrevista.Domain.Interfaces.Services;
using DevBr.Entrevista.Domain.Services;
using DevBr.Entrevista.Infra.Configurations;
using DevBr.Entrevista.Infra.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DevBr.Entrevista.Application.Configurations
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServiceApplication(this IServiceCollection services)
        {
            services.AddTransient<ICandidatoAppService, CandidatoAppService>();
            services.AddTransient<IEntrevistaAppService, EntrevistaAppService>();
            services.AddTransient<IEntrevistadorAppService, EntrevistadorAppService>();
            services.AddTransient<IGrupoPerguntaAppService, GrupoPerguntaAppService>();
            services.AddTransient<IQuestionarioAppService,  QuestionarioAppService>();
            services.AddTransient<IRelatorioAppService, RelatorioAppService>();

            
            services.AddTransient<IAppServiceCore<CandidatoViewModel>, AppServiceCore<CandidatoViewModel, Candidato>>();
            services.AddTransient<IAppServiceCore<EntrevistaViewModel>, AppServiceCore<EntrevistaViewModel, Entrevistar>>();
            services.AddTransient<IAppServiceCore<EntrevistadorViewModel>, AppServiceCore<EntrevistadorViewModel, Entrevistador>>();
            services.AddTransient<IAppServiceCore<GrupoViewModel>, AppServiceCore<GrupoViewModel, GrupoPergunta>>();
            services.AddTransient<IAppServiceCore<QuestionarioViewModel>, AppServiceCore<QuestionarioViewModel, Questionario>>();
            services.AddTransient<IAppServiceCore<RelatorioViewModel>, AppServiceCore<RelatorioViewModel, Relatorio>>();

            return services;
        }

        public static IServiceCollection AddServiceDomain(this IServiceCollection services)
        {
            services.AddTransient<ICandidatoService, CandidatoService>();
            services.AddTransient<IEntrevistaService, EntrevistaService>();
            services.AddTransient<IEntrevistadorService, EntrevistadorService>();
            services.AddTransient<IGrupoPerguntaService, GrupoPerguntaService>();
            services.AddTransient<IQuestionarioService, QuestionarioService>();
            services.AddTransient<IRelatorioService, RelatorioService>();

            services.AddTransient<IServiceCore<Candidato>, ServiceCore<Candidato>>();
            services.AddTransient<IServiceCore<Entrevistar>, ServiceCore<Entrevistar>>();
            services.AddTransient<IServiceCore<Entrevistador>, ServiceCore<Entrevistador>>();
            services.AddTransient<IServiceCore<GrupoPergunta>, ServiceCore<GrupoPergunta>>();
            services.AddTransient<IServiceCore<Questionario>, ServiceCore<Questionario>>();
            services.AddTransient<IServiceCore<Relatorio>, ServiceCore<Relatorio>>();

            return services;
        }

        public static IServiceCollection AddRespositoryInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.RegisterInfra(configuration);
            
            return services;
        }
        public static void AddAutoMapperConfig(this IServiceCollection service)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DomainToViewModelMappingProfile());
                cfg.AddProfile(new ViewModelToDomainMappingProfile());
            });
            IMapper mapper = config.CreateMapper();
            service.AddSingleton(mapper);
        }
    }

 
}
