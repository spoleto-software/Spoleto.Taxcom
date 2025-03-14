using Microsoft.Extensions.DependencyInjection;
using Spoleto.Delivery.Tests;

namespace Spoleto.Taxcom.Tests
{
    public class TaxcomTestsDI : TaxcomTestsBase
    {
        private ServiceProvider _serviceProvider;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            var services = new ServiceCollection();

            var taxcomOptions = ConfigurationHelper.GetTaxcomOptions();
            services.AddSingleton(taxcomOptions);
            services.AddSingleton<ITaxcomProvider, TaxcomProvider>();
            _serviceProvider = services.BuildServiceProvider();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _serviceProvider?.Dispose();
        }

        protected override ITaxcomProvider GetTaxcomProvider() => _serviceProvider.GetRequiredService<ITaxcomProvider>();
    }
}