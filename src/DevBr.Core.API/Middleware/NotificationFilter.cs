using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;
using System.Text.Json;

public class NotificationFilter : IAsyncResultFilter
{
    private readonly NotificationContext _notificationContext;


    public NotificationFilter(NotificationContext notificationContext)
    {
        _notificationContext = notificationContext;
    }

    public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
    {
        if (_notificationContext.HasNotifications)
        {
            context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            context.HttpContext.Response.ContentType = "application/json";

            var response = new ResponseResultCore(HttpStatusCode.BadRequest, null)
            {
                Errors = _notificationContext.Notifications.ToList()
            };

            var result = JsonSerializer.Serialize(response);
            await context.HttpContext.Response.WriteAsync(result);
            return;
        }
        await next();
    }
}

public class ResponseResultCore
{
    public ResponseResultCore(HttpStatusCode statusCode, object? data = default)
    {
        StatusCode = statusCode;
        Data = data;
    }
    public HttpStatusCode StatusCode { get; set; }
    public object? Data { get; set; }
    public ICollection<Notification>? Errors { get; set; }
}
