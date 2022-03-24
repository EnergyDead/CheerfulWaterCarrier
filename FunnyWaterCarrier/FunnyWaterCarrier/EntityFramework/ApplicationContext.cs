using FunnyWaterCarrier.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    public class ApplicationContext : DbContext
    {
        private DbContextOptionsBuilder dbContextOptionsBuilder;

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Subdivision> Subdivision { get; set; }
        public DbSet<Order> Order { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring( DbContextOptionsBuilder options )
        {
            ConfigSettings configSettings = new();
            DbContextConfiguration dbContextConfiguration = configSettings.DbContextConfiguration;
            options.UseSqlServer( dbContextConfiguration.ConnectionString );
        }
    }
}