using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Paymob.Net.Extensions;

namespace Paymob.Net.IntegrationTests.Services
{
    public class PaymobAuthenticationServiceIntegrationTests
    {
        private readonly string _apiKey;
        private readonly IPaymobService? _paymobAuthenticationService;

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

            _paymobAuthenticationService = serviceProvider.GetService<IPaymobService>();

        }


        [Fact]
        public async Task AuthenticateAsync_WithValidApiKey_ReturnsValidToken()
        {
            // ACT
            var result = await _paymobAuthenticationService?.AuthenticateAsync()!;

            // ASSERT
            Assert.NotNull(result);

            Assert.NotEmpty(result.Token);
        }
    }
}