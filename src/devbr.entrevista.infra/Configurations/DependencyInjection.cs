using DevBr.Entrevista.Domain.Interfaces.Repositories;
using DevBr.Entrevista.Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace DevBr.Entrevista.Infra.Configurations
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterInfra(this IServiceCollection services)
        {
            services.AddTransient<ICandidatoRepository, CandidatoRepository>();
            services.AddTransient<IEntrevistadorRepository, EntrevistadorRepository>();
            services.AddTransient<IGrupoPerguntaRepository, GrupoPerguntaRepository>();
            services.AddTransient<IPerguntaRepository, PerguntaRepository>();
            services.AddTransient<IQuestionarioRepository, QuestionarioRepository>();
            services.AddTransient<IRelatorioRepository, RelatorioRepository>();

            return services;
        }

    }
}
