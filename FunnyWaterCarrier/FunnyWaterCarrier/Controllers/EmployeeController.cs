using FunnyWaterCarrier.Data.Interface;
using FunnyWaterCarrier.Data.Model;
using Microsoft.AspNetCore.Mvc;
using System.Net;

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
        public List<Employee> GetEmployes()
        {
            return _employeeService.GetEmployes();
        }

        [HttpGet( "employee/{id}" )]
        public Employee GetEmployee( int id )
        {
            return _employeeService.GetEmployee( id );
        }

        [HttpPost( "employee/{id}/edit" )]
        public HttpResponseMessage EditEmployee( Employee employee )
        {
            _employeeService.EditEmployee( employee );

            return new HttpResponseMessage( GetCode( _employeeService.Errors().Count ) );
        }

        [HttpPost( "employee/{id}/delete" )]
        public HttpResponseMessage DeleteEmployee( int id )
        {
            _employeeService.DeleteEmployee( id );
            return new HttpResponseMessage( GetCode( _employeeService.Errors().Count ) );
        }

        [HttpPost( "employee/add" )]
        public HttpResponseMessage AddEmployee( Employee employee )
        {
            _employeeService.AddEmployee( employee );

            return new HttpResponseMessage( GetCode( _employeeService.Errors().Count ) );
        }

        private static HttpStatusCode GetCode( int errorCount )
        {
            if ( errorCount > 0 )
            {
                return HttpStatusCode.BadRequest;
            }
            return HttpStatusCode.OK;
        }
    }
}
