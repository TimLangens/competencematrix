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
    public class SkillsController : ControllerBase
    {
        /// <summary>
        /// Gets a list of skills
        /// </summary>
        /// <response code="200">Return the list of skill</response>
        /// <response code="500">An error occured. More information in the problem detail</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<ActionResult<IEnumerable<SkillDto>>> GetList()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Request a specific skill
        /// </summary>
        /// <response code="200">Return the requested skill</response>
        /// <response code="500">An error occured. More information in the problem detail</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<ActionResult<SkillDto>> Get(string id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Create a new skill
        /// </summary>
        /// <response code="201">Return the created skill</response>
        /// <response code="500">An error occured. More information in the problem detail</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<ActionResult<SkillDto>> Get([FromBody] SkillDto skill)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update a skill
        /// </summary>
        /// <response code="200">Return the updated skill</response>
        /// <response code="500">An error occured. More information in the problem detail</response>
        [HttpPatch("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<ActionResult<SkillDto>> Update(string id, [FromBody] SkillDto skill)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete a skill
        /// </summary>
        /// <response code="204"></response>
        /// <response code="500">An error occured. More information in the problem detail</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<ActionResult<SkillDto>> Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}
