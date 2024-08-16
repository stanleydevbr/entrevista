using devbr.entrevista.domain.entities;
using devbr.entrevista.domain.entities.questionarios;
using devbr.entrevista.domain.entities.relatorios;
using DevBr.Core.Dominio.Interfaces;
using DevBr.Entrevista.Domain.Interfaces.Repositories;
using DevBr.Entrevista.Infra.Contents;
using DevBr.Entrevista.Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DevBr.Entrevista.Infra.Configurations
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterInfra(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EntrevistaDbContent>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            //services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICandidatoRepository, CandidatoRepository>();
            services.AddScoped<IEntrevistaRepository, EntrevistaRepository>();
            services.AddScoped<IEntrevistadorRepository, EntrevistadorRepository>();
            services.AddScoped<IGrupoPerguntaRepository, GrupoPerguntaRepository>();
            services.AddScoped<IPerguntaRepository, PerguntaRepository>();
            services.AddScoped<IQuestionarioRepository, QuestionarioRepository>();
            services.AddScoped<IRelatorioRepository, RelatorioRepository>();

            services.AddScoped<IRepositoryCore<Candidato>, RepositoryCore<Candidato>>();
            services.AddScoped<IRepositoryCore<devbr.entrevista.domain.entities.Entrevistar>, RepositoryCore<devbr.entrevista.domain.entities.Entrevistar>>();
            services.AddScoped<IRepositoryCore<Entrevistador>, RepositoryCore<Entrevistador>>();
            services.AddScoped<IRepositoryCore<GrupoPergunta>, RepositoryCore<GrupoPergunta>>();
            services.AddScoped<IRepositoryCore<Pergunta>, RepositoryCore<Pergunta>>();
            services.AddScoped<IRepositoryCore<Questionario>, RepositoryCore<Questionario>>();
            services.AddScoped<IRepositoryCore<Relatorio>, RepositoryCore<Relatorio>>();

            return services;
        }

    }
}
