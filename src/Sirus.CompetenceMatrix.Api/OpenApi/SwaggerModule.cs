using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace Sirus.CompetenceMatrix.Api.OpenApi
{
    internal static class SwaggerModule
    {
        internal static void AddOpenApiSpec(this IServiceCollection services)
        {
            services.AddVersionedApiExplorer();
            services.AddApiVersioning(o =>
            {
                o.ReportApiVersions = true;
                o.AssumeDefaultVersionWhenUnspecified = true;
                o.DefaultApiVersion = new ApiVersion(1, 0);
            });
            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, SwaggerConfig>();
            services.AddTransient<IConfigureOptions<SwaggerUIOptions>, SwaggerUiConfig>();
            services.AddSwaggerGen();
        }

        internal static void UseOpenApiSpec(this IApplicationBuilder app, IApiVersionDescriptionProvider provider)
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
    }
}
