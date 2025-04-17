using System.Text.Json.Serialization;

namespace Paymob.Net.Models;

public sealed class SourceData
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = null!;

    [JsonPropertyName("pan")]
    public string Pan { get; set; } = null!;

    [JsonPropertyName("sub_type")]
    public string SubType { get; set; } = null!;
}
