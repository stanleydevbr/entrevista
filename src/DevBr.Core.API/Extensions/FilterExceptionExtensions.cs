using DevBr.Core.API.Errors;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DevBr.Core.API.Extensions
{
    public static class FilterExceptionExtensions
    {
        public static IServiceCollection AddCustomFilterException(this IServiceCollection services)
        {
            services.AddControllers(opt =>
            {
                opt.Filters.Add<CustomExceptionFilterAttribute>();
            });
            return services;
        }

        public static IServiceCollection AddNotificationFilter(this IServiceCollection services)
        {
            services.AddControllers(opt =>
            {
                opt.EnableEndpointRouting  = false;
                opt.Filters.Add<NotificationFilter>();
            }).AddJsonOptions(opt => {
                opt.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
                opt.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
            });
            return services;
        }
    }
}
