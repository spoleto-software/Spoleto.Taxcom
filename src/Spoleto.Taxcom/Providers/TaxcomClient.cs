using Spoleto.RestClient;
using Spoleto.RestClient.Authentication;
using Spoleto.Taxcom.Options;

namespace Spoleto.Taxcom
{
    internal class TaxcomClient : RestHttpClient
    {
        public TaxcomClient(TaxcomOptions taxcomOptions)
            : this(taxcomOptions, CreateNewClient(taxcomOptions), CreateAuthenticator(taxcomOptions), RestClientOptions.Default, true)
        {
        }

        public TaxcomClient(TaxcomOptions taxcomOptions, HttpClient httpClient, IAuthenticator? authenticator = null, RestClientOptions? options = null, bool disposeHttpClient = false)
            : base(httpClient, authenticator, options, disposeHttpClient)
        {
        }

        private static HttpClient CreateNewClient(TaxcomOptions taxcomOptions) //todo: should use Polly?
        {
            var httpClient = new HttpClient { BaseAddress = new Uri(taxcomOptions.ServiceUrl) };

            return httpClient;
        }

        private static IAuthenticator CreateAuthenticator(TaxcomOptions taxcomOptions)
        {
            var authenticator = new TaxcomAuthenticator(taxcomOptions);

            return authenticator;
        }
    }
}
