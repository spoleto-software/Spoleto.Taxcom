using Microsoft.Extensions.DependencyInjection;
using Spoleto.Delivery.Tests;

namespace Spoleto.Taxcom.Tests
{
    public abstract class TaxcomTestsBase
    {
        protected abstract ITaxcomProvider GetTaxcomProvider();

        [Test]
        public async Task GetDocumentList()
        {
            // Arrange
            var provider = GetTaxcomProvider();
            var searchModel = ConfigurationHelper.GetSearchModel<DocumentListSearchModel>();

            // Act
            var model = await provider.GetDocumentListAsync(searchModel);

            // Assert
            Assert.That(model, Is.Not.Null);
        }

        [Test]
        public async Task GetDocumentInfo()
        {
            // Arrange
            var provider = GetTaxcomProvider();
            var searchModel = ConfigurationHelper.GetSearchModel<DocumentInfoSearchModel>();

            // Act
            var model = await provider.GetDocumentInfoAsync(searchModel);

            // Assert
            Assert.That(model, Is.Not.Null);
        }

        [Test]
        public async Task GetShiftList()
        {
            // Arrange
            var provider = GetTaxcomProvider();
            var searchModel = ConfigurationHelper.GetSearchModel<ShiftListSearchModel>();

            // Act
            var model = await provider.GetShiftListAsync(searchModel);

            // Assert
            Assert.That(model, Is.Not.Null);
        }

        [Test]
        public async Task GetShiftInfo()
        {
            // Arrange
            var provider = GetTaxcomProvider();
            var searchModel = ConfigurationHelper.GetSearchModel<ShiftInfoSearchModel>();

            // Act
            var model = await provider.GetShiftInfoAsync(searchModel);

            // Assert
            Assert.That(model, Is.Not.Null);
        }

        [Test]
        public async Task GetDocumentUrl()
        {
            // Arrange
            var provider = GetTaxcomProvider();
            var documentUrlSearchModel = ConfigurationHelper.GetSearchModel<DocumentUrlSearchModel>();

            // Act
            var documentUrlModel = await provider.GetDocumentUrlAsync(documentUrlSearchModel);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(documentUrlModel, Is.Not.Null);
                Assert.That(documentUrlModel.TaxcomReceiptUrl, Is.Not.Null);
            });
        }
    }
}