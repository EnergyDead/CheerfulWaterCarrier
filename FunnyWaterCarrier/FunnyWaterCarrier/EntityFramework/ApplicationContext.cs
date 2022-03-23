using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Subdivision> Subdivision { get; set; }
        public DbSet<Order> Order { get; set; }
        public string DbPath { get; }

        public ApplicationContext( DbContextOptions<ApplicationContext> options )
            : base( options )
        {
            Database.EnsureCreated();
        }
    }
    public class Employee
    {
        public int EmployeeId { get; set; }
        public int SubdivisionId { get; set; }
        public string Name { get; set; }
        public string? Surname { get; set; }
        public string? Patronymic { get; set; }
        public DateTime DateofBirth { get; set; }
        public int Sex { get; set; }
    }

    public class Subdivision
    {
        public int SubdivisionId { get; set; }
        public int SupervisorId { get; set; }
        public string Name { get; set; }
    }

    public class Order
    {
        public int OrderId { get; set; }
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }

    }
}