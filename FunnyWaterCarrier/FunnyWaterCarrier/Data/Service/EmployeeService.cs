using FunnyWaterCarrier.Data.Interface;
using FunnyWaterCarrier.Data.Model;
using FunnyWaterCarrier.Data.Stub;
using Microsoft.AspNetCore.Mvc;

namespace FunnyWaterCarrier.Data.Service
{
    public class EmployeeService : IEmployee
    {
        private readonly EmployeeStub _employes;
        readonly string _connectionString;

        public EmployeeService( string connection )
        {
            _connectionString = connection;
            _employes = new();
        }

        public bool AddEmployee( Employee employee )
        {
            _employes.Employee.Add( employee );
            return true;
        }

        public bool DeleteEmployee( int id )
        {

            var employee = _employes.Employee.FirstOrDefault( employee => employee.Id == id );
            _employes.Employee.Remove( employee );
            return true;
        }

        public bool EditEmployee( Employee newEmployee )
        {
            _employes.Employee.Where( employee => employee.Id == newEmployee.Id ).Select( employee => employee = newEmployee );

            return true;
        }

        public ActionResult<List<Employee>> GetEmployes()
        {
            return _employes.Employee;
        }

        public ActionResult<Employee> GetEmployee( int id )
        {
            return _employes.Employee.FirstOrDefault( employee => employee.Id == id );
        }
    }
}
