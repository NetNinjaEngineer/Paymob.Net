using System.Text.Json.Serialization;

namespace Paymob.Net.Models;

public sealed class Source
{
    [JsonPropertyName("identifier")]
    public string Identifier { get; set; } = null!;

    [JsonPropertyName("subtype")]
    public string Subtype { get; set; } = null!;
}
