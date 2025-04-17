using System.Text.Json.Serialization;

namespace Paymob.Net.Models;

public class OrderRegistrationRequest
{
    [JsonPropertyName("auth_token")]
    public string AuthToken { get; set; } = null!;

    [JsonPropertyName("delivery_needed")]
    public bool DeliveryNeeded { get; set; }

    [JsonPropertyName("merchant_id")]
    public string MerchantId { get; set; } = null!;

    [JsonPropertyName("amount_cents")]
    public int AmountCents { get; set; }

    [JsonPropertyName("currency")]
    public string Currency { get; set; } = null!;

    [JsonPropertyName("merchant_order_id")]
    public string MerchantOrderId { get; set; } = null!;

    [JsonPropertyName("items")]
    public List<OrderItem> Items { get; set; } = [];

    [JsonPropertyName("shipping_data")]
    public ShippingData ShippingData { get; set; } = null!;

    [JsonPropertyName("shipping_details")]
    public ShippingDetails ShippingDetails { get; set; } = null!;
}
