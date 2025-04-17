using System.Net.Http.Headers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Paymob.Net.Extensions
{
    /// <summary>
    /// Extension methods for registering Paymob services with the dependency injection container
    /// </summary>
    public static class PaymobServiceExtensions
    {
        /// <summary>
        /// Adds Paymob services to the specified IServiceCollection with default configuration
        /// </summary>
        /// <param name="services">The IServiceCollection to add services to</param>
        /// <param name="apiKey">Your Paymob API Key</param>
        /// <returns>The IServiceCollection so that additional calls can be chained</returns>
        /// <exception cref="ArgumentNullException">Thrown if services or apiKey is null</exception>
        public static IServiceCollection AddPaymob(this IServiceCollection services, string apiKey)
        {
            ArgumentNullException.ThrowIfNull(services);
            ArgumentException.ThrowIfNullOrEmpty(apiKey, nameof(apiKey));

            return services.AddPaymob(options => options.ApiKey = apiKey);
        }

        /// <summary>
        /// Adds Paymob services to the specified IServiceCollection with custom configuration
        /// </summary>
        /// <param name="services">The IServiceCollection to add services to</param>
        /// <param name="configureOptions">A delegate to configure the PaymobClientOptions</param>
        /// <returns>The IServiceCollection so that additional calls can be chained</returns>
        /// <exception cref="ArgumentNullException">Thrown if services or configureOptions is null</exception>
        public static IServiceCollection AddPaymob(this IServiceCollection services, Action<PaymobClientOptions> configureOptions)
        {
            ArgumentNullException.ThrowIfNull(services);
            ArgumentNullException.ThrowIfNull(configureOptions);

            services.Configure(configureOptions);

            services.AddHttpClient<PaymobClient>((serviceProvider, client) =>
            {
                var paymobOptions = serviceProvider.GetRequiredService<IOptions<PaymobClientOptions>>().Value;
                client.BaseAddress = new Uri(paymobOptions.BaseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.Timeout = TimeSpan.FromSeconds(paymobOptions.TimeoutSeconds);
            });

            services.AddScoped<IPaymobService, PaymobService>(sp =>
            {
                var paymobClient = sp.GetRequiredService<PaymobClient>();
                var paymobOptions = sp.GetRequiredService<IOptions<PaymobClientOptions>>();
                return new PaymobService(paymobClient, paymobOptions);
            });

            return services;
        }

    }
}
