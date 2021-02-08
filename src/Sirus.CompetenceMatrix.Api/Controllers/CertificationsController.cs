using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sirus.CompetenceMatrix.Api.Constants;
using Sirus.CompetenceMatrix.Api.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sirus.CompetenceMatrix.Api.Controllers
{
    [Route(Routes.Default)]
    [ApiController]
    [ApiVersion("1.0")]
    public class CertificationsController : ControllerBase
    {
        /// <summary>
        /// Gets a list of certifications
        /// </summary>
        /// <response code="200">Return the list of certification</response>
        /// <response code="500">An error occured. More information in the problem detail</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<ActionResult<IEnumerable<CertificationDto>>> GetList()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Request a specific certification
        /// </summary>
        /// <response code="200">Return the requested certification</response>
        /// <response code="500">An error occured. More information in the problem detail</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<ActionResult<CertificationDto>> Get(string id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Create a new certification
        /// </summary>
        /// <response code="201">Return the created certification</response>
        /// <response code="500">An error occured. More information in the problem detail</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<ActionResult<CertificationDto>> Get([FromBody] CertificationDto certification)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update a certification
        /// </summary>
        /// <response code="200">Return the updated certification</response>
        /// <response code="500">An error occured. More information in the problem detail</response>
        [HttpPatch("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<ActionResult<CertificationDto>> Update(string id, [FromBody] CertificationDto certification)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete a certification
        /// </summary>
        /// <response code="204"></response>
        /// <response code="500">An error occured. More information in the problem detail</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<ActionResult<CertificationDto>> Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}
