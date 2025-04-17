using System.Text.Json.Serialization;

namespace Paymob.Net.Models;

public sealed class AuthRequest
{
    [JsonPropertyName("api_key")]
    public string ApiKey { get; set; } = null!;
}
