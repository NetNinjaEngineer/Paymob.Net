using Paymob.Net.Models;

namespace Paymob.Net.Interfaces
{
    /// <summary>
    /// Interface for Paymob Authentication services API
    /// </summary>
    public interface IPaymobAuthenticationService
    {
        /// <summary>
        /// Authenticates with the Paymob API and retrieves an authentication token
        /// </summary>
        /// <returns>AuthResponse containing the token and merchant profile information</returns>
        Task<AuthResponse> AuthenticateAsync();
    }
}
