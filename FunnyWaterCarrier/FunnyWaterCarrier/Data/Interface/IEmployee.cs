using FunnyWaterCarrier.Data.Model;
using Microsoft.AspNetCore.Mvc;

namespace FunnyWaterCarrier.Data.Interface
{
    public interface IEmployee
    {
        public ActionResult<List<Employee>> GetEmployes();
        public ActionResult<Employee> GetEmployee( int id );
        public bool AddEmployee( Employee employee );
        public bool EditEmployee( Employee employee );
        public bool DeleteEmployee( int id );
    }
}
