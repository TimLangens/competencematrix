﻿namespace Sirus.CompetenceMatrix.Api.Models
{
    public class EmployeeSkillDto 
    {
        public EmployeeDto Employee { get; set; }
        public SkillDto Skill { get; set; }
        public int Level { get; set; }
        public bool Interested { get; set; }
    }
}
