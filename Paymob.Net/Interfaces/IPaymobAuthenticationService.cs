using Paymob.Net.Models;

namespace Paymob.Net.Interfaces
{
    /// <summary>
    /// Service for handling Paymob authentication.
    /// </summary>
    public interface IPaymobAuthenticationService
    {
        /// <summary>
        /// Authenticates with the Paymob API and retrieves an auth token.
        /// </summary>
        /// <param name="authRequest">The authentication request containing the API key.</param>
        /// <param name="cancellationToken">A token to cancel the operation.</param>
        /// <returns>The authentication response containing the token.</returns>
        Task<AuthResponse> AuthenticateAsync(CancellationToken cancellationToken = default);
    }
}
