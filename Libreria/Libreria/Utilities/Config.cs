using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Utilities
{
    internal class Config
    {
        private string? connectionString;
        // creazione singleton
        private static Config? istanza;
        public static Config getIstanza()
        {
            if (istanza == null)
                istanza = new Config();

            return istanza;
        }
        private Config(){}
        // fine creazione singleton
        public string? GetConnectionString()
        {
            if (connectionString == null)
            {
                ConfigurationBuilder builder = new ConfigurationBuilder();
                builder.SetBasePath(Directory.GetCurrentDirectory());
                builder.AddJsonFile("appSettings.json", optional: false, reloadOnChange: false);

                IConfiguration configuration = builder.Build();

                connectionString = configuration.GetConnectionString("ServerLocale");
            }

            return connectionString;
        }
    }
}
