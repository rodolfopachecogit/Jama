using Microsoft.Extensions.Configuration;

namespace JamaAutomationFramework.Utilities
{
    public static class ConfigurationManager
    {
        private static IConfigurationRoot _configuration;

        static ConfigurationManager()
        {
            // Lee el archivo appsettings.json
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            _configuration = builder.Build();
        }

        public static string GetValue(string key)
        {
            return _configuration[key];
        }
        public static string GetUsername()
        {
            return GetValue("Credentials:Username");
        }

        public static string GetPassword()
        {
            return GetValue("Credentials:Password");
        }
    }
}
