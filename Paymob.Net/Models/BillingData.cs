using System.Text.Json.Serialization;

namespace Paymob.Net.Models;

public class BillingData
{
    [JsonPropertyName("apartment")]
    public string Apartment { get; set; } = null!;

    [JsonPropertyName("email")]
    public string Email { get; set; } = null!;

    [JsonPropertyName("floor")]
    public string Floor { get; set; } = null!;

    [JsonPropertyName("first_name")]
    public string FirstName { get; set; } = null!;

    [JsonPropertyName("street")]
    public string Street { get; set; } = null!;

    [JsonPropertyName("building")]
    public string Building { get; set; } = null!;

    [JsonPropertyName("phone_number")]
    public string PhoneNumber { get; set; } = null!;

    [JsonPropertyName("shipping_method")]
    public string ShippingMethod { get; set; } = null!;

    [JsonPropertyName("postal_code")]
    public string PostalCode { get; set; } = null!;

    [JsonPropertyName("city")]
    public string City { get; set; } = null!;

    [JsonPropertyName("country")]
    public string Country { get; set; } = null!;

    [JsonPropertyName("last_name")]
    public string LastName { get; set; } = null!;

    [JsonPropertyName("state")]
    public string State { get; set; } = null!;
}
