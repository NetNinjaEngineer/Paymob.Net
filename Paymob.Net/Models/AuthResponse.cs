using System.Text.Json.Serialization;

namespace Paymob.Net.Models
{
    public sealed class AuthResponse
    {
        [JsonPropertyName("profile")]
        public Profile Profile { get; set; } = null!;

        [JsonPropertyName("token")]
        public string Token { get; set; } = null!;
    }

}
