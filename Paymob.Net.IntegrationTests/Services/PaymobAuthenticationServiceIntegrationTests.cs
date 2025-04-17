using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Paymob.Net.Extensions;
using Paymob.Net.Interfaces;
using Paymob.Net.Models;

namespace Paymob.Net.IntegrationTests.Services
{
    public class PaymobAuthenticationServiceIntegrationTests
    {
        private readonly IPaymobAuthenticationService? _paymobAuthenticationService;
        private readonly string _apiKey;

        public PaymobAuthenticationServiceIntegrationTests()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            _apiKey = config["Paymob:ApiKey"] ?? throw new ArgumentNullException("API key not found in configuration.");

            var services = new ServiceCollection();

            services.AddPaymob(_apiKey);

            var serviceProvider = services.BuildServiceProvider();

            _paymobAuthenticationService = serviceProvider.GetService<IPaymobAuthenticationService>();

        }


        [Fact]
        public async Task AuthenticateAsync_WithValidApiKey_ReturnsValidToken()
        {
            var authRequest = new AuthRequest { ApiKey = _apiKey };

            // ACT
            var result = await _paymobAuthenticationService?.AuthenticateAsync(authRequest)!;

            // ASSERT
            Assert.NotNull(result);

            Assert.NotEmpty(result.Token);
        }
    }
}