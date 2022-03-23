using System;

namespace FunnyWaterCarrier.Data.Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public int SubdivisionId { get; set; }
        public string Name { get; set; }
        public string? Surname { get; set; }
        public string? Patronymic { get; set; }
        public DateTime DateofBirth { get; set; }
        public int Sex { get; set; }
    }
}
