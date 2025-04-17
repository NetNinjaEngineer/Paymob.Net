using Microsoft.Extensions.Options;
using Paymob.Net.Interfaces;
using Paymob.Net.Models;

namespace Paymob.Net.Services
{
    /// <summary>
    /// Implementation of the Paymob authentication service.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="PaymobAuthenticationService"/> class.
    /// </remarks>
    /// <param name="client">The Paymob client.</param>
    /// <param name="paymobOptions"></param>
    public class PaymobAuthenticationService(
        PaymobClient client,
        IOptions<PaymobClientOptions> paymobOptions) : IPaymobAuthenticationService
    {
        private readonly PaymobClientOptions _paymobOptions = paymobOptions.Value;

        /// <inheritdoc/>
        public async Task<AuthResponse> AuthenticateAsync(CancellationToken cancellationToken = default)
        {
            return await client.AuthenticateAsync(new AuthRequest { ApiKey = _paymobOptions.ApiKey! }, cancellationToken);
        }
    }
}
