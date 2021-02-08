using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.IO;
using System.Reflection;

namespace Sirus.CompetenceMatrix.Api.OpenApi
{
    public class SwaggerConfig : IConfigureOptions<SwaggerGenOptions>
    {
        private readonly IApiVersionDescriptionProvider _provider;

        public SwaggerConfig(IApiVersionDescriptionProvider provider)
        {
            _provider = provider;
        }

        public void Configure(SwaggerGenOptions options)
        {
            foreach (var description in _provider.ApiVersionDescriptions)
            {
                var info = new OpenApiInfo()
                {
                    Title = $"Sirus Competence Matrix API - {description.ApiVersion}",
                    Version = description.ApiVersion.ToString(),
                    Description = ".NET Core Restful Web API.\n This service is used to manage the Sirus Competences."
                };

                if (description.IsDeprecated)
                {
                    info.Description += "<br />This API version has been deprecated.";
                }

                options.SwaggerDoc(description.GroupName, info);
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                options.IncludeXmlComments(xmlPath);               
            }
        }
    }
}