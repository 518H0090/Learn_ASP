using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;

namespace WebApplication1.ExtenMiddleware
{
    public static class ExtenMiddle2
    {
        public static IApplicationBuilder UseMiddleSimple(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExtenMiddle>();
        }
    }
}
