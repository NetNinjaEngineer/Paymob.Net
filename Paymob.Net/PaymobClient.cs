using System.Text.Json;
using Paymob.Net.Models;

namespace Paymob.Net
{
    public sealed class PaymobClient(HttpClient httpClient) : IDisposable
    {
        private string _authToken = string.Empty;

        public async Task<AuthResponse> AuthenticateAsync(string apiKey)
        {
            var authRequest = new AuthRequest { ApiKey = apiKey };
            var response = await PostAsync<AuthResponse>("/auth/tokens", authRequest);
            _authToken = response.Token;
            return response!;
        }

        public void Dispose() => httpClient.Dispose();

        private async Task<T> PostAsync<T>(string endpointUrl, object data)
        {
            var serializedData = JsonSerializer.Serialize(data, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            var content = new StringContent(serializedData, System.Text.Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync(_baseUrl + endpointUrl, content);

            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<T>(responseContent,
                new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase })!;
        }

    }
}
