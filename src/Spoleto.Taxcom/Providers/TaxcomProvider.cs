using Spoleto.RestClient;
using Spoleto.Taxcom.Options;

namespace Spoleto.Taxcom
{
    /// <summary>
    /// Провайдер для работы с сервисом "Такском-Касса".
    /// </summary>
    /// <remarks>
    /// https://lk-ofd.taxcom.ru/ApiHelp/
    /// </remarks>
    public class TaxcomProvider : ITaxcomProvider
    {
        private readonly TaxcomClient _taxcomClient;

        public TaxcomProvider(TaxcomOptions options)
        {
            if (options is null)
                throw new ArgumentNullException(nameof(options));

            // Validates if the options are valid
            options.Validate();

            _taxcomClient = new TaxcomClient(options);
        }

        #region IDisposable
        bool _disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (disposing && !_disposed)
            {
                _disposed = true;
                _taxcomClient?.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion

        public DocumentListModel GetDocumentList(DocumentListSearchModel searchModel)
            => GetDocumentListAsync(searchModel).GetAwaiter().GetResult();

        /// <inheritdoc/>
        public async Task<DocumentListModel> GetDocumentListAsync(DocumentListSearchModel searchModel)
        {
            var restRequest = new RestRequestFactory(RestHttpMethod.Get, $"DocumentList")
                .WithQueryString(searchModel)
                .Build();

            var result = await _taxcomClient.ExecuteAsync<DocumentListModel>(restRequest).ConfigureAwait(false);

            return result;
        }

        /// <inheritdoc/>
        public DocumentInfoModel GetDocumentInfo(DocumentInfoSearchModel searchModel)
            => GetDocumentInfoAsync(searchModel).GetAwaiter().GetResult();

        /// <inheritdoc/>
        public async Task<DocumentInfoModel> GetDocumentInfoAsync(DocumentInfoSearchModel searchModel)
        {
            var restRequest = new RestRequestFactory(RestHttpMethod.Get, $"DocumentInfo")
                .WithQueryString(searchModel)
                .Build();

            var result = await _taxcomClient.ExecuteAsync<DocumentInfoModel>(restRequest).ConfigureAwait(false);

            return result;
        }

        /// <inheritdoc/>
        public ShiftListModel GetShiftList(ShiftListSearchModel searchModel)
            => GetShiftListAsync(searchModel).GetAwaiter().GetResult();

        /// <inheritdoc/>
        public async Task<ShiftListModel> GetShiftListAsync(ShiftListSearchModel searchModel)
        {
            var restRequest = new RestRequestFactory(RestHttpMethod.Get, $"ShiftList")
                .WithQueryString(searchModel)
                .Build();

            var result = await _taxcomClient.ExecuteAsync<ShiftListModel>(restRequest).ConfigureAwait(false);

            return result;
        }

        /// <inheritdoc/>
        public ShiftInfoModel GetShiftInfo(ShiftInfoSearchModel searchModel)
            => GetShiftInfoAsync(searchModel).GetAwaiter().GetResult();

        /// <inheritdoc/>
        public async Task<ShiftInfoModel> GetShiftInfoAsync(ShiftInfoSearchModel searchModel)
        {
            var restRequest = new RestRequestFactory(RestHttpMethod.Get, $"ShiftInfo")
                .WithQueryString(searchModel)
                .Build();

            var result = await _taxcomClient.ExecuteAsync<ShiftInfoModel>(restRequest).ConfigureAwait(false);

            return result;
        }

        /// <inheritdoc/>
        public DocumentUrlModel GetDocumentUrl(DocumentUrlSearchModel searchModel)
            => GetDocumentUrlAsync(searchModel).GetAwaiter().GetResult();

        /// <inheritdoc/>
        public async Task<DocumentUrlModel> GetDocumentUrlAsync(DocumentUrlSearchModel searchModel)
        {
            var restRequest = new RestRequestFactory(RestHttpMethod.Get, $"DocumentURL")
                .WithQueryString(searchModel)
                .Build();

            var result = await _taxcomClient.ExecuteAsync<DocumentUrlModel>(restRequest).ConfigureAwait(false);

            return result;
        }
    }
}
