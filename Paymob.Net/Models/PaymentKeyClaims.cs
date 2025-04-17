using System.Text.Json.Serialization;

namespace Paymob.Net.Models;

public sealed class PaymentKeyClaims
{
    [JsonPropertyName("user_id")]
    public int UserId { get; set; }

    [JsonPropertyName("amount_cents")]
    public int AmountCents { get; set; }

    [JsonPropertyName("currency")]
    public string Currency { get; set; }

    [JsonPropertyName("integration_id")]
    public int IntegrationId { get; set; }

    [JsonPropertyName("order_id")]
    public int OrderId { get; set; }

    [JsonPropertyName("exp")]
    public int Exp { get; set; }

    [JsonPropertyName("billing_data")]
    public BillingData BillingData { get; set; }

    [JsonPropertyName("lock_order_when_paid")]
    public bool LockOrderWhenPaid { get; set; }
}
