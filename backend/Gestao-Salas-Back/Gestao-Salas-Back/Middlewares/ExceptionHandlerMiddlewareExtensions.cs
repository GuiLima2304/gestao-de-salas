using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestao_Salas_Back.Middlewares
{
    public static class ExceptionHandlerMiddlewareExtensions
    {
		public static IServiceCollection AddExceptionHandlerMiddleware(this IServiceCollection services)
		{
			return services.AddTransient<ExceptionHandlerMiddleware>();
		}

		public static void UseExceptionHandlerMiddleware(this IApplicationBuilder app)
		{
			app.UseMiddleware<ExceptionHandlerMiddleware>();
		}
	}
}
