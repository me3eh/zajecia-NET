using Microsoft.Net.Http.Headers;
using UAParser;
namespace Middleware
{

    public class CustomMiddleware
    {
        private RequestDelegate _next;
        public CustomMiddleware(RequestDelegate next)
        {
                _next = next;
        }

        public Task Invoke(HttpContext context)
        {
            Console.WriteLine(context.Request);
            
            var userAgent = context.Request.Headers["User-Agent"];
            string uaString = Convert.ToString(userAgent[0]);
            var uaParser = Parser.GetDefault();
            ClientInfo c = uaParser.Parse(uaString);
            string browserName = c.UserAgent.Family;

            if (browserName.Contains("IE") || browserName.Contains("Edge") )
            {
                context.Response.Redirect("https://www.mozilla.org/pl/firefox/new/");
            }
            return _next(context);  
        }
    }

    public static class MyMiddlewareExtensions
    {
        public static IApplicationBuilder UseMyMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomMiddleware>();
        }
    }
}
