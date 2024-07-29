#region Documentación
/****************************************************************************************************
* API REST                                                      
****************************************************************************************************
* Unidad        : <.NET/C# Middleware>                                                                      
* DescripciÓn   : <Logica de negocio para realizar el llamado de los Middleware>                                                      
* Autor         : <Pedro Castro>
* Fecha         : <16-07-2024>
* ===========   ============       ========================================================================= 
* 26/07/2016   Pedro Castro         1. Documentacion
***************************************************************************************************/
#endregion Documentación

using CampusVirtualWebApi.Middlewares;

namespace CampusVirtualWebApi.Middlewares
{
    public class TimeMiddleware
    {

        readonly RequestDelegate next;

        public TimeMiddleware(RequestDelegate nextRequest)
        {
            next = nextRequest;
        }

        public async Task Invoke(Microsoft.AspNetCore.Http.HttpContext context)
        {
            await next(context);

            if (context.Request.Query.Any(p => p.Key == "time"))
            {
                await context.Response.WriteAsync(DateTime.Now.ToString());
            }
        }
    }
    public static class TimeMiddlewareExpresion

    {
        public static IApplicationBuilder UseTimeMiddleware(this IApplicationBuilder builder)

        {
            return builder.UseMiddleware<TimeMiddleware>();
        }
    }

}
