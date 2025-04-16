using Paymob.Net.Interfaces;
using Paymob.Net.Models;

namespace Paymob.Net.Services
{
    /// <summary>
    /// Service for handling Paymob authentication
    /// </summary>
    /// <param name="paymobClient"></param>
    /// <param name="apiKey"></param>
    internal sealed class PaymobAuthenticationService(PaymobClient paymobClient, string apiKey) : IPaymobAuthenticationService
    {
        /// <inheritdoc/>
        public async Task<AuthResponse> AuthenticateAsync() => await paymobClient.AuthenticateAsync(apiKey);
    }
}
