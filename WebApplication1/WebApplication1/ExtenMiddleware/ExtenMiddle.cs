using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace WebApplication1.ExtenMiddleware
{
    public class ExtenMiddle
    {

        private readonly RequestDelegate _requestDelegate;
       public ExtenMiddle(RequestDelegate next)
        {
            _requestDelegate = next;
        }

        public async Task Invoke(HttpContext context)
        {
            await context.Response.WriteAsync("Hello 35");
            await _requestDelegate(context);
            await context.Response.WriteAsync("Hello 29");
        }
    }
}
