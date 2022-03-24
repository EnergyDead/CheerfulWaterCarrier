using FunnyWaterCarrier.Data.Model;

namespace FunnyWaterCarrier.Data.Interface
{
    public interface IEmployee
    {
        public List<Employee> GetEmployes();
        public Employee GetEmployee( int id );
        public void AddEmployee( Employee employee );
        public void EditEmployee( Employee employee );
        public void DeleteEmployee( int id );
        public List<string> Errors();
    }
}
