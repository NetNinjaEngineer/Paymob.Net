using System.Text.Json.Serialization;

namespace Paymob.Net.Models;

public sealed class Merchant
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("phones")]
    public List<string> Phones { get; set; } = [];

    [JsonPropertyName("company_emails")]
    public List<string> CompanyEmails { get; set; } = [];

    [JsonPropertyName("company_name")]
    public string CompanyName { get; set; } = null!;

    [JsonPropertyName("state")]
    public string State { get; set; } = null!;

    [JsonPropertyName("country")]
    public string Country { get; set; } = null!;

    [JsonPropertyName("city")]
    public string City { get; set; } = null!;

    [JsonPropertyName("postal_code")]
    public string PostalCode { get; set; } = null!;

    [JsonPropertyName("street")]
    public string Street { get; set; } = null!;
}
