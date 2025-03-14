using Spoleto.Taxcom.Options;

namespace Spoleto.Taxcom
{
    /// <summary>
    /// TaxcomProvider factory used to create an instance of <see cref="TaxcomProvider"/>.
    /// </summary>
    public class TaxcomProviderFactory
    {
        private TaxcomOptions? _taxcomOptions;
        private TaxcomProvider? _taxcomProvider;

        /// <summary>
        /// Sets the options of the Taxcom provider.
        /// </summary>
        /// <remarks>
        /// <see href="https://lk-ofd.taxcom.ru/ApiHelp/login_i_parol.html"/>
        /// </remarks>
        /// <param name="integratorId">The integrator ID.</param>
        /// <param name="login">The login.</param>
        /// <param name="password">The password.</param>
        /// <param name="serviceUrl">The Taxcom service url.</param>
        /// <returns>The <see cref="TaxcomProviderFactory"/> instance is provided to support method chaining capabilities.</returns>
        public TaxcomProviderFactory WithOptions(string integratorId, string login, string password, string serviceUrl = "https://api-lk-ofd.taxcom.ru/API/v2/")
           => WithOptions(x =>
           {
               x.ServiceUrl = serviceUrl;
               x.IntegratorId = integratorId;
               x.Login = login;
               x.Password = password;
           });

        /// <summary>
        /// Sets the options of the Taxcom provider.
        /// </summary>
        /// <param name="config">The action to configure the <see cref="TaxcomOptions"/> for the Taxcom provider.</param>
        /// <returns>The <see cref="TaxcomProviderFactory"/> instance is provided to support method chaining capabilities.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="config"/> is null.</exception>
        public TaxcomProviderFactory WithOptions(Action<TaxcomOptions> config)
        {
            if (config is null)
                throw new ArgumentNullException(nameof(config));

            // loads the options
            var options = new TaxcomOptions();
            config(options);

            // validates the options
            options.Validate();

            _taxcomOptions = options;

            return this;
        }

        /// <summary>
        /// Sets the options of the Taxcom provider.
        /// </summary>
        /// <param name="options">The options for the Taxcom provider.</param>
        /// <returns>The <see cref="TaxcomProviderFactory"/> instance is provided to support method chaining capabilities.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="options"/> is null.</exception>
        public TaxcomProviderFactory WithOptions(TaxcomOptions options)
        {
            if (options is null)
                throw new ArgumentNullException(nameof(options));

            // validates the options
            options.Validate();

            _taxcomOptions = options;

            return this;
        }

        /// <summary>
        /// Sets the Taxcom provider.
        /// </summary>
        /// <param name="config">The action to configure the <see cref="TaxcomOptions"/> for the Taxcom provider.</param>
        /// <returns>The <see cref="TaxcomProviderFactory"/> instance is provided to support method chaining capabilities.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="config"/> is null.</exception>
        public TaxcomProviderFactory WithTaxcomProvider(TaxcomProvider taxcomProvider)
        {
            if (taxcomProvider is null)
                throw new ArgumentNullException(nameof(taxcomProvider));

            _taxcomProvider = taxcomProvider;

            return this;
        }

        /// <summary>
        /// Creates the TaxcomProvider instance.
        /// </summary>
        /// <returns>Instance of <see cref="TaxcomProvider"/>.</returns>
        public ITaxcomProvider Build() => _taxcomProvider ?? new TaxcomProvider(_taxcomOptions);
    }
}
