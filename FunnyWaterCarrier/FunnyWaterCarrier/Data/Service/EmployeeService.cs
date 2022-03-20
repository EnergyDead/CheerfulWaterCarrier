using FunnyWaterCarrier.Data.Interface;
using FunnyWaterCarrier.Data.Model;
using Microsoft.AspNetCore.Mvc;

namespace FunnyWaterCarrier.Data.Service
{
    public class EmployeeService : IEmployee
    {
        public ActionResult AddEmployee( Employee employee )
        {
            throw new NotImplementedException();
        }

        public ActionResult DeleteEmployee( int id )
        {
            throw new NotImplementedException();
        }

        public ActionResult<Employee> EditEmployee( Employee employee )
        {
            throw new NotImplementedException();
        }

        public ActionResult<List<Employee>> GetEmployes()
        {
            throw new NotImplementedException();
        }

        public ActionResult<Employee> GetEmployee( int id )
        {
            throw new NotImplementedException();
        }
    }
}
