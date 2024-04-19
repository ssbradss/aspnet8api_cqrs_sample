public class BearerTokenMiddleware
{
    private readonly RequestDelegate _next;

    public BearerTokenMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    /// <summary>
    /// Inserts the "Bearer " keyword before the Authentication string in the HTTP request header if the request does not contain it.
    /// </summary>
    /// <param name="context"></param>
    /// <returns></returns>
    public async Task Invoke(HttpContext context)
    {
        string authorizationHeader = context.Request.Headers["Authorization"];
        if (!string.IsNullOrEmpty(authorizationHeader) && !authorizationHeader.StartsWith("Bearer "))
        {
            context.Request.Headers["Authorization"] = "Bearer " + authorizationHeader;
        }

        await _next(context);
    }
}

public static class BearerTokenMiddlewareExtensions
{
    public static IApplicationBuilder UseBearerTokenMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<BearerTokenMiddleware>();
    }
}
