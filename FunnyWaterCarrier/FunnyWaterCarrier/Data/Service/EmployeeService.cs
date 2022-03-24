using EntityFramework;
using FunnyWaterCarrier.Data.Interface;
using FunnyWaterCarrier.Data.Model;

namespace FunnyWaterCarrier.Data.Service
{
    public class EmployeeService : IEmployee
    {
        private List<string> _errors;
        public List<string> Errors()
        {
            return _errors;
        }
        public EmployeeService()
        {
            _errors = new();
        }
        public void AddEmployee( Employee employee )
        {
            try
            {
                using ( ApplicationContext db = new ApplicationContext() )
                {
                    db.Employee.Add( employee );
                    db.SaveChanges();
                }
            }
            catch ( Exception error )
            {
                _errors.Add( error.Message );
                throw;
            }
        }

        public void DeleteEmployee( int id )
        {
            try
            {
                using ( ApplicationContext db = new ApplicationContext() )
                {
                    var employee = db.Employee.FirstOrDefault( employee => employee.EmployeeId == id );
                    db.Employee.Remove( employee );
                    db.SaveChanges();
                }
            }
            catch ( Exception error )
            {
                _errors.Add( error.Message );
                throw;
            }
        }

        public void EditEmployee( Employee newEmployee )
        {
            try
            {
                using ( ApplicationContext db = new ApplicationContext() )
                {
                    db.Employee.Update( newEmployee );
                    db.SaveChanges();
                }
            }
            catch ( Exception error )
            {
                _errors.Add( error.Message );
                throw;
            }
        }

        public List<Employee> GetEmployes()
        {
            List<Employee> employes = new();
            try
            {
                using ( ApplicationContext db = new ApplicationContext() )
                {
                    employes = db.Employee.ToList();
                }
            }
            catch ( Exception error )
            {
                _errors.Add( error.Message );
                throw;
            }
            return employes;
        }

        public Employee GetEmployee( int id )
        {
            Employee employee = new();
            try
            {
                using ( ApplicationContext db = new ApplicationContext() )
                {
                    employee = db.Employee.FirstOrDefault( employee => employee.EmployeeId == id );
                }
            }
            catch ( Exception error )
            {
                _errors.Add( error.Message );
                throw;
            }
            return employee ?? ( new() );
        }
    }
}
