using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using Paymob.Net.Models;

namespace Paymob.Net
{
    /// <summary>
    /// Client for interacting with the Paymob payment gateway API.
    /// </summary>
    public sealed class PaymobClient : IDisposable
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _jsonOptions;
        private string _authToken = string.Empty;

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymobClient"/> class.
        /// </summary>
        /// <param name="httpClient">The HTTP client to use for API requests.</param>
        public PaymobClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _jsonOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
        }

        /// <summary>
        /// Authenticates with the Paymob API and retrieves an auth token.
        /// </summary>
        /// /// <param name="authRequest">The authentication request containing the API key.</param>
        /// <param name="cancellationToken">A token to cancel the operation.</param>
        /// <returns>The authentication response.</returns>
        public async Task<AuthResponse> AuthenticateAsync(AuthRequest authRequest, CancellationToken cancellationToken = default)
        {
            var response = await PostAsync<AuthResponse>("auth/tokens", authRequest, cancellationToken);
            _authToken = response.Token;
            return response;
        }

        /// <summary>
        /// Registers a new order with the Paymob API.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<OrderRegistrationResponse> RegisterOrderAsync(OrderRegistrationRequest request)
        {
            EnsureAuthenticated();
            return await PostAsync<OrderRegistrationResponse>("ecommerce/orders", request);
        }

        /// <summary>
        /// Requests a payment key from the Paymob API.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<PaymentKeyResponse> RequestPaymentKeyAsync(PaymentKeyRequest request)
        {
            EnsureAuthenticated();
            return await PostAsync<PaymentKeyResponse>("/acceptance/payment_keys", request);
        }

        /// <summary>
        /// Pay for an order using the Paymob API.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<PaymentResponse> ProcessPaymentAsync(PaymentRequest request)
        {
            EnsureAuthenticated();
            return await PostAsync<PaymentResponse>("/acceptance/payments/pay", request);
        }

        /// <summary>
        /// Gets the status of a transaction using the Paymob API.
        /// </summary>
        /// <param name="transactionId"></param>
        /// <returns></returns>
        public async Task<TransactionResponse> GetTransactionAsync(string transactionId)
        {
            EnsureAuthenticated();
            return await GetAsync<TransactionResponse>($"/acceptance/transactions/{transactionId}");
        }

        /// <summary>
        /// Refunds a transaction using the Paymob API.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<RefundResponse> RefundTransactionAsync(RefundRequest request)
        {
            EnsureAuthenticated();
            return await PostAsync<RefundResponse>("/acceptance/void_refund/refund", request);
        }

        private async Task<T> GetAsync<T>(string requestUri, CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetAsync(requestUri, cancellationToken);

            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync(cancellationToken);

                throw new PaymobApiException(
                    $"API request failed with status code {(int)response.StatusCode}",
                    response.StatusCode,
                    errorContent);
            }


            var content = await response.Content.ReadAsStringAsync(cancellationToken);

            var result = JsonSerializer.Deserialize<T>(content, _jsonOptions);

            return result == null ? throw new JsonException($"Failed to deserialize response to type {typeof(T).Name}") : result;

        }


        /// <summary>
        /// Disposes of resources used by the client.
        /// </summary>
        public void Dispose() => _httpClient.Dispose();

        private async Task<T> PostAsync<T>(string endpointUrl, object data, CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.PostAsJsonAsync(endpointUrl, data, _jsonOptions, cancellationToken);

            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync(cancellationToken);

                throw new PaymobApiException(
                    $"API request failed with status code {(int)response.StatusCode}",
                    response.StatusCode,
                    errorContent);
            }

            var responseContent = await response.Content.ReadAsStringAsync(cancellationToken);

            var result = JsonSerializer.Deserialize<T>(responseContent, _jsonOptions);
            return result == null ? throw new JsonException($"Failed to deserialize response to type {typeof(T).Name}") : result;
        }

        private void EnsureAuthenticated()
        {
            if (string.IsNullOrEmpty(_authToken))
                throw new InvalidOperationException("Client is not authenticated. Call AuthenticateAsync() first.");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _authToken);
        }

    }
}
