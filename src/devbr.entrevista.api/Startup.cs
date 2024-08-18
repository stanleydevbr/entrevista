using DevBr.Entrevista.Application.Configurations;
using DevBr.Core.API.Configurations;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using DevBr.Core.API.Errors;
using DevBr.Core.API.Extensions;
using DevBr.Core.Dominio.Entidades;
using DevBr.Core.Dominio.Notificacoes;
using devbr.entrevista.domain.entities;

namespace DevBr.Entrevista.Api
{
    public class Startup : IStartup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddNotificationFilter();
     

            services.AddControllersWithViews(options =>
            {
                options.EnableEndpointRouting = false;
            });

            services.AddDevBrSwaggerConfiguration();

            services.AddAutoMapperConfig();
            services.AddServiceApplication();
            services.AddServiceDomain();
            services.AddRespositoryInfrastructure(Configuration);
            services.AddScoped<NotificationContext>();
            
            //services.AddMiddlewareFilter();


        }
        public void Configure(WebApplication app, IWebHostEnvironment environment, IApiVersionDescriptionProvider provider)
        {

            if (environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseRouting();

            app.ConfigureCustomExceptionMiddleware();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseDevBrSwaggerConfiguration(environment, provider, "entrevista");

        }
    }
}
