using Paymob.Net.Interfaces;
using Paymob.Net.Models;

namespace Paymob.Net.Services
{
    /// <summary>
    /// Implementation of the authentication service for Paymob API
    /// </summary>
    /// <param name="paymobClient"></param>
    public sealed class PaymobAuthService(PaymobClient paymobClient) : IPaymobAuthService
    {
        /// <inheritdoc/>
        public async Task<AuthResponse> AuthenticateAsync(string apiKey) => await paymobClient.AuthenticateAsync(apiKey);
    }
}
