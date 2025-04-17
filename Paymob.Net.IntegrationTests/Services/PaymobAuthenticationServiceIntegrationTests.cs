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
            _apiKey = "ZXlKaGJHY2lPaUpJVXpVeE1pSXNJblI1Y0NJNklrcFhWQ0o5LmV5SmpiR0Z6Y3lJNklrMWxjbU5vWVc1MElpd2ljSEp2Wm1sc1pWOXdheUk2T1RrNE9USXpMQ0p1WVcxbElqb2lhVzVwZEdsaGJDSjkuVVQ2Z3VqU2I1SkthNy03NGZDLTZ2c1dzOE1pd2h4bjRhRTdqMlMwb1l4QTZWYmlPRTBQa3J3cHBDMkoyX0NqOVcwZDQ5UTJsbi1IQTU4Ujlva2ZsVnc=";

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