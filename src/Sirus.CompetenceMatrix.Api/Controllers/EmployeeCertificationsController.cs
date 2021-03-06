﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sirus.CompetenceMatrix.Api.Constants;
using Sirus.CompetenceMatrix.Api.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sirus.CompetenceMatrix.Api.Controllers
{
    [Route(Routes.Employees + "certifications")]
    [ApiController]
    [ApiVersion("1.0")]
    public class EmployeeCertificationsController : ControllerBase
    {
        /// <summary>
        /// Gets a list of employee certifications
        /// </summary>
        /// <response code="200">Return the list of employee certification</response>
        /// <response code="500">An error occured. More information in the problem detail</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<ActionResult<IEnumerable<EmployeeCertificationDto>>> GetList(string employeeId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Request a specific employee certification
        /// </summary>
        /// <response code="200">Return the requested employee certification</response>
        /// <response code="500">An error occured. More information in the problem detail</response>
        [HttpGet("{certificateId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<ActionResult<EmployeeCertificationDto>> Get(string employeeId, string certificateId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Create a new employee certification
        /// </summary>
        /// <response code="201">Return the created employee certification</response>
        /// <response code="500">An error occured. More information in the problem detail</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<ActionResult<EmployeeCertificationDto>> Get(string employeeId, [FromBody] EmployeeCertificationDto employeeCertification)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update an employee certification
        /// </summary>
        /// <response code="200">Return the updated employee certification</response>
        /// <response code="500">An error occured. More information in the problem detail</response>
        [HttpPatch("{certificateId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<ActionResult<EmployeeCertificationDto>> Update(string employeeId, string certificateId, [FromBody] EmployeeCertificationDto employeeCertification)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete an employee certification
        /// </summary>
        /// <response code="204"></response>
        /// <response code="500">An error occured. More information in the problem detail</response>
        [HttpDelete("{certificateId}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Task<ActionResult<EmployeeCertificationDto>> Delete(string employeeId, string certificateId)
        {
            throw new NotImplementedException();
        }
    }
}
