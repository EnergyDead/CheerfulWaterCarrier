namespace EntityFramework
{
    public class DbContextConfiguration
    {
        public DbContextConfiguration() { }

        public DbContextConfiguration( string connectionString )
        {
            ConnectionString = connectionString;
        }

        public string ConnectionString { get; set; }

        public bool EnableQueryLog { get; set; }
    }
}
