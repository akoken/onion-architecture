using App.Infrastructure.Interfaces;
using System.Configuration;

namespace App.Infrastructure.Data.Services
{
    public class ConfigService : IConfigService
    {
        public string Connection
        {
            get
            {
                string connectionString = string.Empty;
                var settings = ConfigurationManager.ConnectionStrings["AzureConnection"];
                if (settings != null)
                {
                    connectionString = settings.ConnectionString;
                }
                return connectionString;
            }
        }
    }
}
