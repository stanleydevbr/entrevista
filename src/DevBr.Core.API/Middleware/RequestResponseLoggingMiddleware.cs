using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

public class RequestResponseMiddleware
{
    private readonly RequestDelegate _next;

    private readonly NotificationContext _notificationContext;

    public RequestResponseMiddleware(RequestDelegate next, NotificationContext notificationContext)
    {
        _next = next;
        _notificationContext = notificationContext;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        // Código a ser executado antes da requisição
        LogRequest(context);

        await _next(context);

        // Código a ser executado depois da requisição
        //OnResultExecutionAsync(context);
    }

    private void LogRequest(HttpContext context)
    {
        // Lógica para logar a requisição
        // Exemplo: Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path}");
    }

    private async Task OnResultExecutionAsync(HttpContext context, ResultExecutionDelegate next)
    {
        if (_notificationContext.HasNotifications)
        {
            context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            context.Response.ContentType = "application/json";

            var notifications = JsonSerializer.Serialize(_notificationContext.Notifications);
            await context.Response.WriteAsync(notifications);
            return;
        }
        await next();
    }

}
