using FunnyWaterCarrier.Data.Model;
using Microsoft.AspNetCore.Mvc;

namespace FunnyWaterCarrier.Data.Interface
{
    public interface IEmployeeService
    {
        public ActionResult<List<Employee>> GetEmployes();
        public ActionResult<Employee> GetEmployee( int id );
        public ActionResult AddEmployee( Employee employee );
        public ActionResult<Employee> EditEmployee( Employee employee );
        public ActionResult DeleteEmployee( int id );
    }
}
