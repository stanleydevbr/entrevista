using DevBr.Entrevista.Application.Configurations;
using DevBr.Core.API.Configurations;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using DevBr.Core.API.Errors;
using DevBr.Core.API.Extensions;

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

            services.AddControllers();
            services.AddControllersWithViews(options =>
            {
                options.EnableEndpointRouting = false;
            });
            services.AddCustomFilterException();

            services.AddDevBrSwaggerConfiguration();

            services.AddAutoMapperConfig();
            services.AddServiceApplication();
            services.AddServiceDomain();
            services.AddRespositoryInfrastructure(Configuration);


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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                // Outros endpoints, se necessário
            });

            //app.UseMvc()
            //    .UseApiVersioning()
            //    .UseMvcWithDefaultRoute();

            app.UseDevBrSwaggerConfiguration(environment, provider, "entrevista");
            //app.ConfigureExceptionHandler();


            //app.UseSwaggerConfiguration();
            //app.UseApiConfiguration(environment);
        }
    }
}
