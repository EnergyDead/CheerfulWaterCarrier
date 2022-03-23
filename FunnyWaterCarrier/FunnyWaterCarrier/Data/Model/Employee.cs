using System;

namespace FunnyWaterCarrier.Data.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Surname { get; set; }
        public string? Patronymic { get; set; }
        public DateTime Birthday { get; set; }
        public Sex Sex { get; set; }
        public int SubdivisionId { get; set; }
    }

    public enum Sex : int
    {
        male,
        female
    }
}
