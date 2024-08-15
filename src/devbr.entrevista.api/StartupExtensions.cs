using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace DevBr.Entrevista.Api
{
    public static class StartupExtensions
    {
        public static WebApplicationBuilder UseStartup<TSetup>(this WebApplicationBuilder WebAppBuilder) where TSetup : IStartup
        {
            var startup = Activator.CreateInstance(typeof(TSetup), WebAppBuilder.Configuration) as IStartup;
            if (startup == null) throw new ArgumentException("Classe Startup.cs inválida!");

            startup.ConfigureServices(WebAppBuilder.Services);
            var app = WebAppBuilder.Build();
            var provider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();
            startup.Configure(app, app.Environment, provider);
            app.Run();
            return WebAppBuilder;
        }
    }
}
