using System.Net.Http.Headers;
using System.Text.Json;
using Paymob.Net.Models;

namespace Paymob.Net
{
    public sealed class PaymobClient : IDisposable
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;
        private readonly string _baseUrl = "https://accept.paymob.com/api/";
        private string _authToken = string.Empty;

        public PaymobClient(HttpClient httpClient, string apiKey)
        {
            _httpClient = httpClient;
            _apiKey = apiKey;
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<AuthResponse> AuthenticateAsync()
        {
            var authRequest = new AuthRequest { ApiKey = _apiKey };
            var response = await PostAsync<AuthResponse>("/auth/tokens", authRequest);
            _authToken = response.Token;
            return response!;
        }

        public void Dispose() => _httpClient.Dispose();

        private async Task<T> PostAsync<T>(string endpointUrl, object data)
        {
            var serializedData = JsonSerializer.Serialize(data, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            var content = new StringContent(serializedData, System.Text.Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_baseUrl + endpointUrl, content);

            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<T>(responseContent,
                new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase })!;
        }

    }
}
