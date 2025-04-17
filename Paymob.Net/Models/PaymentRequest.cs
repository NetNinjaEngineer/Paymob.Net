using System.Text.Json.Serialization;

namespace Paymob.Net.Models;

public sealed class PaymentRequest
{
    [JsonPropertyName("source")]
    public Source Source { get; set; } = null!;

    [JsonPropertyName("payment_token")]
    public string PaymentToken { get; set; } = null!;
}
