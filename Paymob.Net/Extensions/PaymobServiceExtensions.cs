using System.Net.Http.Headers;
using Microsoft.Extensions.DependencyInjection;
using Paymob.Net.Interfaces;
using Paymob.Net.Services;

namespace Paymob.Net.Extensions
{
    /// <summary>
    /// Extension methods for registering Paymob services with the dependency injection container
    /// </summary>
    public static class PaymobServiceExtensions
    {
        /// <summary>
        ///  Adds Paymob services to the specified IServiceCollection
        /// </summary>
        /// <param name="services">The IServiceCollection to add services to</param>
        /// <param name="apiKey">Your Paymob API Key</param>
        /// <returns>The IServiceCollection so that additional calls can be chained</returns>
        /// <exception cref="ArgumentNullException">Throws ArgumentNullException if the services is null</exception>
        public static IServiceCollection AddPaymob(this IServiceCollection services, string apiKey)
        {
            ArgumentNullException.ThrowIfNull(services);

            if (string.IsNullOrEmpty(apiKey))
                throw new ArgumentNullException(nameof(apiKey));

            services.AddHttpClient<PaymobClient>(client =>
            {
                client.BaseAddress = new Uri("https://accept.paymob.com/api");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            });

            services.AddScoped<IPaymobAuthService, PaymobAuthService>();


            return services;
        }
    }
}
