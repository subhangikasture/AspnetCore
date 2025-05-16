namespace CustomMiddleware
{
    public class LoggerMiddleware
    {
        private readonly RequestDelegate _next;
        public LoggerMiddleware(RequestDelegate next)
        {
                _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            // Log the request
            Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path}");
            // Call the next middleware in the pipeline
            await _next(context);
            // Log the response
            Console.WriteLine($"Response: {context.Response.StatusCode}");
        }

    }
}
