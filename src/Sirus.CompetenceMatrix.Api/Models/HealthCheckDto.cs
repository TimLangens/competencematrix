using System;

namespace Sirus.CompetenceMatrix.Api.Models
{
    public class HealthCheckDto
    {
        public string Status { get; set; }
        public string ApplicationName { get; set; }
        public string EnvironmentName { get; set; }
        public DateTimeOffset Date { get; set; }
    }
}
