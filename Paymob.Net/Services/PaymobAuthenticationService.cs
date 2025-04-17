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
    public class PaymobAuthenticationService(PaymobClient client) : IPaymobAuthenticationService
    {
        /// <inheritdoc/>
        public async Task<AuthResponse> AuthenticateAsync(AuthRequest authRequest, CancellationToken cancellationToken = default)
        {
            return await client.AuthenticateAsync(authRequest, cancellationToken);
        }
    }
}
