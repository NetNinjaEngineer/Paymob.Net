using System.Text.Json.Serialization;

namespace Paymob.Net.Models;

public sealed class ShippingDetails
{
    [JsonPropertyName("notes")]
    public string Notes { get; set; } = null!;

    [JsonPropertyName("number_of_packages")]
    public int NumberOfPackages { get; set; }

    [JsonPropertyName("weight")]
    public int Weight { get; set; }

    [JsonPropertyName("weight_unit")]
    public string WeightUnit { get; set; } = null!;

    [JsonPropertyName("length")]
    public int Length { get; set; }

    [JsonPropertyName("width")]
    public int Width { get; set; }

    [JsonPropertyName("height")]
    public int Height { get; set; }

    [JsonPropertyName("contents")]
    public string Contents { get; set; } = null!;
}
