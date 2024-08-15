using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace DevBr.Entrevista.Api
{
    public interface IStartup
    {
        IConfiguration Configuration { get; }
        void Configure(WebApplication app, IWebHostEnvironment environment, IApiVersionDescriptionProvider provider);
        void ConfigureServices(IServiceCollection services);
    }
}
