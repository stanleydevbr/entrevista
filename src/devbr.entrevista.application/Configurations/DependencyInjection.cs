using Microsoft.Extensions.DependencyInjection;

namespace DevBr.Entrevista.Application.Configurations
{
    public static class DependencyInjection
    {
        public static IServiceCollection ApplicationRegister(this IServiceCollection services)
        {
            services.AddTransient<ICandidatoService, CandidatoService>();

            return services;
        }
    }
}
