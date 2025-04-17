using System.Text.Json.Serialization;

namespace Paymob.Net.Models;

public class OrderRegistrationRequest
{
    [JsonPropertyName("auth_token")]
    public string AuthToken { get; set; } = null!;

    [JsonPropertyName("api_source")]
    public string ApiSource { get; set; } = null!;

    [JsonPropertyName("amount_cents")]
    public string AmountCents { get; set; } = null!;

    [JsonPropertyName("currency")]
    public string Currency { get; set; } = null!;

    [JsonPropertyName("shipping_data")]
    public ShippingData ShippingData { get; set; } = null!;

    [JsonPropertyName("integrations")]
    public List<int> Integrations { get; set; } = [];

    [JsonPropertyName("items")]
    public List<OrderItem> Items { get; set; } = [];

    [JsonPropertyName("delivery_needed")]
    public string DeliveryNeeded { get; set; } = null!;
}
