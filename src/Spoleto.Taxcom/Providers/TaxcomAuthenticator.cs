using Spoleto.RestClient;
using Spoleto.RestClient.Authentication;
using Spoleto.RestClient.Serializers;
using Spoleto.Taxcom.Options;

namespace Spoleto.Taxcom
{
    public class TaxcomAuthenticator : DynamicAuthenticator
    {
        public const string TokenTypeName = "Session-Token";

        /// <summary>
        /// Истек срок действия маркера доступа.
        /// </summary>
        private const int TokenExpiredApiCode = 2109;

        private readonly TaxcomOptions _taxcomOptions;

        public TaxcomAuthenticator(TaxcomOptions taxcomOptions) : base(TokenTypeName)
        {
            _taxcomOptions = taxcomOptions;
        }

        protected override async Task<string> GetAuthenticationToken(IRestClient client)
        {
            var restRequest = new RestRequestFactory(RestHttpMethod.Post, "Login")
                .WithJsonContent(new { login = _taxcomOptions.Login, password = _taxcomOptions.Password })
                .WithHeader("Integrator-ID", _taxcomOptions.IntegratorId)
                .Build();

            var tokenModel = await client.ExecuteAsync<TokenModel>(restRequest).ConfigureAwait(false);

            return tokenModel.SessionToken;
        }

        public override async Task<bool> IsExpired(HttpResponseMessage response)
        {
            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                if (response.Content?.Headers.ContentType?.MediaType == ContentTypes.ApplicationJson)
                {
                    var result = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                    if (!string.IsNullOrEmpty(result))
                    {
                        var errorModel = SerializationManager.Deserialize<ErrorModel>(result);
                        if (errorModel.ApiErrorCode == TokenExpiredApiCode)
                        {
                            return true;
                        }
                    }
                }
            }

            return await base.IsExpired(response).ConfigureAwait(false);
        }
    }
}
