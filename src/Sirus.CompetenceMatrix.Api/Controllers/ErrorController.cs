using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sirus.CompetenceMatrix.Api.Constants;
using Sirus.CompetenceMatrix.Api.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sirus.CompetenceMatrix.Api.Controllers
{
    [ApiController]
    [ApiVersionNeutral]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ErrorController : ControllerBase
    {
        [Route(Routes.Error)]
        public IActionResult Error()
        {
            var context = HttpContext.Features.Get<IExceptionHandlerFeature>();

            return context.Error switch
            {
                NotFoundException _ => NotFound(),
                InvalidParametersException _ => Problem(statusCode: 400, title: context.Error.Message),
                _ => Problem(title: context.Error.Message),
            };
        }

        [Route(Routes.FullError)]
        public IActionResult FullError()
        {
            var context = HttpContext.Features.Get<IExceptionHandlerFeature>();

            return context.Error switch
            {
                NotFoundException _ => NotFound(),
                InvalidParametersException _ => Problem(
                        statusCode: 400,
                        detail: context.Error.StackTrace,
                        title: context.Error.Message),
                _ => Problem(
                        detail: context.Error.StackTrace,
                        title: context.Error.Message),
            };
        }
    }
}
