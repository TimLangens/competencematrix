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
    public class EmployeeSkillsController : ControllerBase
    {
        /// <summary>
        /// Gets a list of employee skills
        /// </summary>
        /// <response code="200">Return the list of employeeSkills</response>
        /// <response code="500">An error occured. More information in the problem detail</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<ActionResult<IEnumerable<EmployeeSkillDto>>> GetList()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Request a specific employee skill
        /// </summary>
        /// <response code="200">Return the requested employeeSkills</response>
        /// <response code="500">An error occured. More information in the problem detail</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<ActionResult<EmployeeSkillDto>> Get(string id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Create a new employee skill
        /// </summary>
        /// <response code="201">Return the created employeeSkills</response>
        /// <response code="500">An error occured. More information in the problem detail</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<ActionResult<EmployeeSkillDto>> Get([FromBody] EmployeeSkillDto employeeSkills)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update an employee skill
        /// </summary>
        /// <response code="200">Return the updated employeeSkills</response>
        /// <response code="500">An error occured. More information in the problem detail</response>
        [HttpPatch("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<ActionResult<EmployeeSkillDto>> Update(string id, [FromBody] EmployeeSkillDto employeeSkills)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete an employee skill
        /// </summary>
        /// <response code="204"></response>
        /// <response code="500">An error occured. More information in the problem detail</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<ActionResult<EmployeeSkillDto>> Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}
