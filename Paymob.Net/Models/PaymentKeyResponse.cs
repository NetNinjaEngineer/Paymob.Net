using System.Text.Json.Serialization;

namespace Paymob.Net.Models;

public sealed class PaymentKeyResponse
{
    [JsonPropertyName("token")]
    public string Token { get; set; } = null!;
}
