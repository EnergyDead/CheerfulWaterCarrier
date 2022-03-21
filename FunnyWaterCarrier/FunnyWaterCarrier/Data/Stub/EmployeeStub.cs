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
                new Employee() { Id = 0, Name = "Коля" },
                new Employee() { Id = 1, Name = "Леха" },
                new Employee() { Id = 2, Name = "Вася" }
            };
        }
    }
}
