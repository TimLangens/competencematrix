using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Sirus.CompetenceMatrix.Api.Constants;
using Sirus.CompetenceMatrix.Api.Models;
using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace Sirus.CompetenceMatrix.Api.Registrations
{
    public static class HealthCheckModule
    {
        public static void MapHealthCheckEndpoint(this IEndpointRouteBuilder routeBuilder, IWebHostEnvironment hostEnvironment)
        {
            routeBuilder.MapHealthChecks(Routes.HealthCheck, new HealthCheckOptions()
            {
                ResponseWriter = (c, r) => WriteHealthCheckResponse(c, r, hostEnvironment)
            });
        }

        private static Task WriteHealthCheckResponse(HttpContext context, HealthReport report, IWebHostEnvironment hostEnvironment)
        {
            var healthCheck = new HealthCheckDto
            {
                Status = report.Status.ToString(),
                ApplicationName = hostEnvironment.ApplicationName,
                EnvironmentName = hostEnvironment.EnvironmentName,
                Date = DateTime.Now,
            };

            context.Response.ContentType = "application/json";
            return context.Response.WriteAsync(JsonSerializer.Serialize(healthCheck));
        }
    }
}
