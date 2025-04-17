using System.Text.Json.Serialization;

namespace Paymob.Net.Models;

public sealed class RefundResponse
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("pending")]
    public bool Pending { get; set; }

    [JsonPropertyName("amount_cents")]
    public int AmountCents { get; set; }

    [JsonPropertyName("success")]
    public bool Success { get; set; }

    [JsonPropertyName("is_voided")]
    public bool IsVoided { get; set; }

    [JsonPropertyName("is_refunded")]
    public bool IsRefunded { get; set; }

    [JsonPropertyName("refunded_amount_cents")]
    public int RefundedAmountCents { get; set; }

    [JsonPropertyName("error_occured")]
    public bool ErrorOccured { get; set; }

    [JsonPropertyName("has_parent_transaction")]
    public bool HasParentTransaction { get; set; }
}
