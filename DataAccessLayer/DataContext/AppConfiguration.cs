using Microsoft.Extensions.Configuration;
using System.IO;

namespace DataAccessLayer.DataContext
{
    class AppConfiguration
    {
        public string SqlConnectionString { get; set; }

        public AppConfiguration()
        {
            ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            string path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");

            configurationBuilder.AddJsonFile(path, false);

            IConfigurationRoot root = configurationBuilder.Build();
            IConfigurationSection appSettings = root.GetSection("ConnectionStrings:DefaultConnection");

            SqlConnectionString = appSettings.Value;
        }
    }
}
