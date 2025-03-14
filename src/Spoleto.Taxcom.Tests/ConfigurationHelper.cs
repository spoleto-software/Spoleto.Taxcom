using Microsoft.Extensions.Configuration;
using Spoleto.Taxcom.Options;

namespace Spoleto.Delivery.Tests
{
    internal class ConfigurationHelper
    {
        private static readonly IConfigurationRoot _config;

        static ConfigurationHelper()
        {
            _config = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json", optional: true)
               .AddUserSecrets("15da364b-99d4-490f-be3b-ffd93249275c")
               .Build();
        }

        public static IConfigurationRoot Configuration => _config;

        public static TaxcomOptions GetTaxcomOptions()
        {
            var options = _config.GetSection(nameof(TaxcomOptions)).Get<TaxcomOptions>()!;

            return options;
        }

        public static T GetSearchModel<T>() where T : class
        {
            var model = _config.GetSection(typeof(T).Name).Get<T>();

            return model;
        }
    }
}
