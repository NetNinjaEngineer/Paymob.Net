using System.Text.Json.Serialization;

namespace Paymob.Net.Models;

public sealed class RefundRequest
{
    [JsonPropertyName("auth_token")]
    public string AuthToken { get; set; } = null!;

    [JsonPropertyName("transaction_id")]
    public int TransactionId { get; set; }

    [JsonPropertyName("amount_cents")]
    public int AmountCents { get; set; }
}
