using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Sirus.CompetenceMatrix.Api.Constants;
using Sirus.CompetenceMatrix.Api.OpenApi;

namespace Sirus.CompetenceMatrix.Api
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOpenApiSpec();
            services.AddControllers();
            services.AddHealthChecks();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IApiVersionDescriptionProvider versionProvider)
        {
            if (env.IsProduction())
            {
                app.UseExceptionHandler(Routes.Error);
            }
            else
            {
                app.UseDeveloperExceptionPage();
                app.UseOpenApiSpec(versionProvider);
                app.UseExceptionHandler(Routes.FullError);
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHealthChecks(Routes.HealthCheck);
            });
        }
    }
}
