using FunnyWaterCarrier.Data.Model;

namespace FunnyWaterCarrier.Data.Stub
{
    public class EmployeeStub
    {
        private List<Employee> _employes;
        public List<Employee> Employee { get => _employes; set => _employes = value; }

        public EmployeeStub()
        {
            _employes = new List<Employee>()
            {
                new Employee() { Id = 0, Name = "Коля", Birthday = new DateTime(1999, 7, 12), Sex = Sex.male, SubdivisionId = 0, Surname = "Иванов"  },
                new Employee() { Id = 1, Name = "Леха", Birthday = new DateTime(1999, 7, 12), Sex = Sex.male, SubdivisionId = 1, Surname = "Лежаков" },
                new Employee() { Id = 2, Name = "Вася", Birthday = new DateTime(1999, 7, 12), Sex = Sex.male, SubdivisionId = 1, Surname = "Пиколов" },
                new Employee() { Id = 3, Name = "Игорь", Birthday = new DateTime(1999, 7, 12), Sex = Sex.male, SubdivisionId = 0, Surname = "Рыбак" }
            };
        }
    }
}
