using FunnyWaterCarrier.Data.Interface;
using FunnyWaterCarrier.Data.Model;
using Microsoft.AspNetCore.Mvc;

namespace FunnyWaterCarrier.Controllers
{
    [ApiController]
    [Route( "api/" )]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee _employeeService;

        public EmployeeController( ILogger<EmployeeController> logger, IEmployee employeeService )
        {
            _employeeService = employeeService;
        }

        [HttpGet( "employes" )]
        public ActionResult<List<Employee>> GetEmployes()
        {
            return _employeeService.GetEmployes();
        }

        [HttpGet( "employee/{id}" )]
        public ActionResult<Employee> GetEmployee( int id )
        {
            return _employeeService.GetEmployee( id );
        }

        [HttpPost( "employee/{id}/edit" )]
        public bool EditEmployee( Employee employee )
        {
            return _employeeService.EditEmployee( employee );
        }

        [HttpPost( "employee/{id}/delete" )]
        public bool DeleteEmployee( int id )
        {
            return _employeeService.DeleteEmployee( id );
        }

        [HttpPost( "employee/add" )]
        public bool AddEmployee( Employee employee )
        {
            return _employeeService.AddEmployee( employee );
        }
    }
}
