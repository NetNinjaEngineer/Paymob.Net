using System.Text.Json.Serialization;

namespace Paymob.Net.Models;

public sealed class OrderItem
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("amount_cents")]
    public int AmountCents { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; } = null!;

    [JsonPropertyName("quantity")]
    public int Quantity { get; set; }
}
