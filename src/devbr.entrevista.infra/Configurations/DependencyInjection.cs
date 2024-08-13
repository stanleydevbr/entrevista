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

            return services;
        }

    }
}
