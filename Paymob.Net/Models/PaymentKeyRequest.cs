using System.Text.Json.Serialization;

namespace Paymob.Net.Models;

public sealed class PaymentKeyRequest
{
    [JsonPropertyName("auth_token")]
    public string AuthToken { get; set; }

    [JsonPropertyName("amount_cents")]
    public int AmountCents { get; set; }

    [JsonPropertyName("expiration")]
    public int Expiration { get; set; }

    [JsonPropertyName("order_id")]
    public int OrderId { get; set; }

    [JsonPropertyName("billing_data")]
    public BillingData BillingData { get; set; }

    [JsonPropertyName("currency")]
    public string Currency { get; set; }

    [JsonPropertyName("integration_id")]
    public int IntegrationId { get; set; }

    [JsonPropertyName("lock_order_when_paid")]
    public bool LockOrderWhenPaid { get; set; }
}
