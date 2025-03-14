using Spoleto.Delivery.Tests;

namespace Spoleto.Taxcom.Tests
{
    public class TaxcomTestsFactory : TaxcomTestsBase
    {
        private ITaxcomProvider _taxcomProvider;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            var taxcomOptions = ConfigurationHelper.GetTaxcomOptions();
            _taxcomProvider = new TaxcomProviderFactory().WithOptions(taxcomOptions).Build();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _taxcomProvider?.Dispose();
        }

        protected override ITaxcomProvider GetTaxcomProvider() => _taxcomProvider;
    }
}