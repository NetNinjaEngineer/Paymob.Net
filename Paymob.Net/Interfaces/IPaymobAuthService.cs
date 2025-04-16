using Paymob.Net.Models;

namespace Paymob.Net.Interfaces
{
    /// <summary>
    /// Interface for authentication with Paymob API
    /// </summary>
    public interface IPaymobAuthService
    {
        /// <summary>
        /// Authenticates with the Paymob API and retrieves an authentication token
        /// </summary>
        /// <param name="apiKey">apikey from paymob dashboard</param>
        /// <returns>AuthResponse containing the token and merchant profile information</returns>
        Task<AuthResponse> AuthenticateAsync(string apiKey);
    }
}
