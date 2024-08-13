using DevBr.Entrevista.Application.Interfaces.Applications;
using DevBr.Entrevista.Application.Services;
using DevBr.Entrevista.Domain.Interfaces.Services;
using DevBr.Entrevista.Domain.Services;
using DevBr.Entrevista.Infra.Configurations;
using Microsoft.Extensions.DependencyInjection;

namespace DevBr.Entrevista.Application.Configurations
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServiceApplication(this IServiceCollection services)
        {
            services.AddTransient<ICandidatoAppService, CandidatoAppService>();

            return services;
        }

        public static IServiceCollection AddServiceDomain(this IServiceCollection services)
        {
            services.AddTransient<ICandidatoService, CandidatoService>();

            return services;
        }

        public static IServiceCollection AddRespositoryInfrastructure(this IServiceCollection services)
        {
            services.RegisterInfra();

            return services;
        }
    }
}
