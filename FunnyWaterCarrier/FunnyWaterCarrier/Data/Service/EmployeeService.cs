using FunnyWaterCarrier.Data.Interface;
using FunnyWaterCarrier.Data.Model;
using FunnyWaterCarrier.Data.Stub;
using Microsoft.AspNetCore.Mvc;

namespace FunnyWaterCarrier.Data.Service
{
    public class EmployeeService : IEmployee
    {
        private readonly EmployeeStub _employes;
        public EmployeeService()
        {
            _employes = new();
        }

        public ActionResult AddEmployee( Employee employee )
        {
            _employes.Employee.Add( employee );
            return null;
        }

        public ActionResult DeleteEmployee( int id )
        {

            var employee = _employes.Employee.FirstOrDefault( employee => employee.Id == id );
            _employes.Employee.Remove( employee );
            return null;
        }

        public ActionResult<Employee> EditEmployee( Employee newEmployee )
        {
            _employes.Employee.Where( employee => employee.Id == newEmployee.Id ).Select( employee => employee = newEmployee );

            return null;
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
