using Microsoft.Extensions.Configuration;

namespace NTierToDoApp.BusinessLayer
{
    static class Configuration
    {
        public static string ConnectionString 
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../NTierToDoApp.API"));
                configurationManager.AddJsonFile("appsettings.json");

                return configurationManager.GetConnectionString("NTierToDoAppDbContext");
            }
        }
    }
}
