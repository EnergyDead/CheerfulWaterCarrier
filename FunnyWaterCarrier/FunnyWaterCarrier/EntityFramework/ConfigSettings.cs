using Microsoft.Extensions.Configuration;

namespace EntityFramework
{
    public class ConfigSettings
    {
        private readonly IConfiguration _serviceConfiguration;

        #region Congigs

        public DbContextConfiguration DbContextConfiguration => _serviceConfiguration.GetSection( "DbConnection" ).Get<DbContextConfiguration>();

        #endregion

        public ConfigSettings()
        {
            _serviceConfiguration = GetServiceConfiguration();
        }

        private IConfiguration GetServiceConfiguration()
        {
            string env = "dev"; // Environment.GetEnvironmentVariable ("ASPNETCORE_RUNTIME_ENVIRONMENT");
            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder().AddJsonFile( "appsettings.json", false ); // Базовая конфигурация

            string additioonalCofigFile = $"appsettings.{env}.json";
            if ( File.Exists( additioonalCofigFile ) )
            {
                configurationBuilder.AddJsonFile( additioonalCofigFile, false ); // Переопределения для окружения
            }

            return configurationBuilder.Build();
        }
    }
}
