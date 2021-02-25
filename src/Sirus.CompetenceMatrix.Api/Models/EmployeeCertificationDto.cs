namespace Sirus.CompetenceMatrix.Api.Models
{
    public class EmployeeCertificationDto
    {
        public EmployeeDto Employee { get; set; }
        public CertificationDto Certification { get; set; }
        public string Year { get; set; }

    }
}
