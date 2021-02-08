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
    public class EmployeesController : ControllerBase
    {
        /// <summary>
        /// Gets a list of employees
        /// </summary>
        /// <response code="200">Return the list of employee</response>
        /// <response code="500">An error occured. More information in the problem detail</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<ActionResult<IEnumerable<EmployeeDto>>> GetList()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Request a specific employee
        /// </summary>
        /// <response code="200">Return the requested employee</response>
        /// <response code="500">An error occured. More information in the problem detail</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<ActionResult<EmployeeDto>> Get(string id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Create a new employee
        /// </summary>
        /// <response code="201">Return the created employee</response>
        /// <response code="500">An error occured. More information in the problem detail</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<ActionResult<EmployeeDto>> Get([FromBody] EmployeeDto employee)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update an employee
        /// </summary>
        /// <response code="200">Return the updated employee</response>
        /// <response code="500">An error occured. More information in the problem detail</response>
        [HttpPatch("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<ActionResult<EmployeeDto>> Update(string id, [FromBody] EmployeeDto employee)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete an employee
        /// </summary>
        /// <response code="204"></response>
        /// <response code="500">An error occured. More information in the problem detail</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<ActionResult<EmployeeDto>> Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}
