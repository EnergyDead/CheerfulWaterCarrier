using EntityFramework;
using FunnyWaterCarrier.Data.Interface;
using FunnyWaterCarrier.Data.Model;
using FunnyWaterCarrier.Data.Stub;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FunnyWaterCarrier.Data.Service
{
    public class EmployeeService : IEmployee
    {
        readonly string _connectionString;

        public EmployeeService( string connectionString )
        {
            _connectionString = connectionString;
        }

        public bool AddEmployee( Employee employee )
        {
            using ( ApplicationContext db = new ApplicationContext() )
            {
                db.Employee.Add( employee );
                db.SaveChanges();
            }

            return true;
        }

        public bool DeleteEmployee( int id )
        {
            using ( ApplicationContext db = new ApplicationContext() )
            {
                var employee = db.Employee.FirstOrDefault( employee => employee.EmployeeId == id );
                db.Employee.Remove( employee );
                db.SaveChanges();
            }
            return true;
        }

        public bool EditEmployee( Employee newEmployee )
        {
        using ( ApplicationContext db = new ApplicationContext() )
        {
            db.Employee.Update( newEmployee );
            db.SaveChanges();
        }
            return true;
        }

        public ActionResult<List<Employee>> GetEmployes()
        {
            List<Employee> employes;
            using ( ApplicationContext db = new ApplicationContext() )
            {
                employes = db.Employee.ToList();
            }
            return employes;
        }

        public ActionResult<Employee> GetEmployee( int id )
        {
            Employee employee;
            using ( ApplicationContext db = new ApplicationContext() )
            {
                employee = db.Employee.FirstOrDefault( employee => employee.EmployeeId == id );
            }
            return employee ?? ( new() );
        }
    }
}
